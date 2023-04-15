using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR_Simple.Business.Exceptions
{
    [Serializable]
    public class TooOldException : Exception
    {

        public TooOldException(DateTime? dateNaissance)
       : base(String.Format("Date de naissance invalide :  Les personnes de plus de 150 ans peuvent être enregistrées : {0}", dateNaissance))
        {

        }
       
    }
}
