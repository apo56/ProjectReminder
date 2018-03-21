using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BO
{
    [Table("Connaissance")]
    public class Connaissance
    {

        public  int Id { get; set; }

        public string Nom { get; set; }

        public bool PossedeConnaissance { get; set; }

        //utile plus tard pour faire un pourcentage 
        public int NiveauConnaissance { get; set; }

        public List<string> UrlDoc { get; set; }
        
        public string Version { get; set; }


    }
}