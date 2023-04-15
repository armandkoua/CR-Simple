using CR_Simple.Business;
using CR_Simple.Data.Repository;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult ListPersonne()
        {
            var resultat = listerLesPersonnesUsecase.DoExecute();
            return View(resultat);
        }



        [HttpPost(Name = "CreatePersonne")]
        public IActionResult CreatePersonne()
        {
            return View();
        }
    }
}
