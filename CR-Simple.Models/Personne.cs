namespace CR_Simple.Models
{
    public class Personne
    {
        public string    Nom { get; private set; } 
        public string    Prenom { get; private set; }
        public DateTime?    DateNaissance { get; private set; }

        public Personne(string nom ,string prenom, DateTime? dateNaissance)
        {
            this.Nom = nom;
            this.DateNaissance = dateNaissance;
            this.Prenom = prenom;
        }

        public int Age
        {
            get
            {
                if(DateNaissance.HasValue)
                {
                    return DateTime.Now.Year - DateNaissance.Value.Year;
                }

                return 0;
            }
        }
    }
}