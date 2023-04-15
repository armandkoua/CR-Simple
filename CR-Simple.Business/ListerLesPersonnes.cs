using CR_Simple.Data.Repository;
using CR_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR_Simple.Business
{
    public class ListerLesPersonnes
    {
        private readonly IPersonneRepository personneRepository;

        public ListerLesPersonnes(IPersonneRepository personneRepository)
        {
            this.personneRepository = personneRepository;
        }

        public List<Personne> DoExecute()
        {
            return this.personneRepository.GetPersonnes().OrderBy( p => p.Nom).ToList();            
        }
    }
}
