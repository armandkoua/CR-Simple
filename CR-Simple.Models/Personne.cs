namespace CR_Simple.Models
{
    [Serializable]
    public class Personne
    {
        public int Id { get; set; }
        public string    Nom { get;  set; } 
        public string    Prenom { get;  set; }
        public DateTime?    DateNaissance { get;  set; }

        public Personne()
        {
            
        }

        public Personne(string nom ,string prenom, DateTime? dateNaissance)
        {
            this.Nom = nom;
            this.DateNaissance = dateNaissance;
            this.Prenom = prenom;            
        }

        public Personne(string nom, string prenom, DateTime? dateNaissance, int id)
        {
            this.Nom = nom;
            this.DateNaissance = dateNaissance;
            this.Prenom = prenom;
            this.Id = id;
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