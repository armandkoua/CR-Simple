using CR_Simple.Models;

namespace CR_Simple.Data.Repository
{
    public interface IPersonneRepository
    {
        Personne Create(Personne toCreate);
        List<Personne> GetPersonnes();
    }
}