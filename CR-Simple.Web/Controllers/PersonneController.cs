using CR_Simple.Business;
using CR_Simple.Data.Repository;
using CR_Simple.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CR_Simple.Web.Controllers
{
     
    [ApiController]
    [Route("[Controller]")]
    public class PersonneController : Controller
    {

        CreerUnePersonne createUseCase;
        ListerLesPersonnes listerLesPersonnesUsecase;
        private readonly IPersonneRepository personneRepository;

        public PersonneController(IPersonneRepository personneRepository)
        {
            this.personneRepository = personneRepository;
            createUseCase = new CreerUnePersonne(personneRepository);
            listerLesPersonnesUsecase = new ListerLesPersonnes(personneRepository);
        }

        [HttpGet(Name = "ListPersonnes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Personne>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ListPersonne()
        {
            var resultat = listerLesPersonnesUsecase.DoExecute();
            if(resultat != null  && resultat.Any())
            {
                Ok(resultat);
            }
            return NotFound();
        }



        [HttpPost(Name = "CreatePersonne")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreatePersonne(Personne toCreate)
        {
            try
            {
                var resultat = createUseCase.DoExecute(toCreate);
                return CreatedAtAction(nameof(CreatePersonne), new { id = toCreate.Id }, toCreate);               
            }
            catch (Exception ex)
            {
                return BadRequest();               
            }
        }
    }
}
