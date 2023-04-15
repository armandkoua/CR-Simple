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
        List<Personne>  _listeInMemory =  new List<Personne>();
        public InMemoryPersonneRepository()
        {
            _listeInMemory = new List<Personne>()
            {
                new Personne("Koua", "Armand", new DateTime(1986, 1, 6), 1),
                new Personne("Tom", "Joel", new DateTime(1986, 1, 6), 2),
                new Personne("Andrew", "Armand", new DateTime(1986, 1, 6), 3),
                new Personne("Koua", "Armand", new DateTime(1986, 1, 6), 4)
            };                
        }


        public Personne Create(Personne toCreate)
        {
            toCreate.Id = _listeInMemory.Select(p => p.Id).Max() + 1;
            _listeInMemory.Add(toCreate);

            return toCreate;
        }

        public List<Personne> GetPersonnes()
        {
            return _listeInMemory;
        }
    }
}
