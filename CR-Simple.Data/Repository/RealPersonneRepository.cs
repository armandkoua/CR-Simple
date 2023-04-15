using CR_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR_Simple.Data.Repository
{
    public class RealPersonneRepository : IPersonneRepository
    {
        public Personne Create(Personne toCreate)
        {

            return toCreate;
        }


        public List<Personne> GetPersonnes()
        {
            var personnes = new List<Personne>();

            return personnes;
        }
    }
}
