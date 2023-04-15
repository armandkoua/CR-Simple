using CR_Simple.Data.Repository;
using CR_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR_Simple.Business
{
    public class CreerUnePersonne
    {
        private readonly IPersonneRepository personneRepository;

        public CreerUnePersonne(IPersonneRepository personneRepository)
        {
            this.personneRepository = personneRepository;
        }

        public Personne DoExecute(Personne personne )
        {

            personne = this.personneRepository.Create(personne);
            return personne;
        }
    }
}
