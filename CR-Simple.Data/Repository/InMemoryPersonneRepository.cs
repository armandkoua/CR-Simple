using CR_Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR_Simple.Data.Repository
{
    public class InMemoryPersonneRepository : IPersonneRepository
    {
        public Personne Create(Personne toCreate)
        {
            throw new NotImplementedException();
        }

        public List<Personne> GetPersonnes()
        {
            return new List<Personne>()
            {
                new Personne("Koua","Armand" ,new DateTime(1986,1,6))
            };
        }
    }
}
