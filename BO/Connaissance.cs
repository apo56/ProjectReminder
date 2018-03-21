using System.Collections.Generic;

namespace BO
{
    public class Connaissance
    {

        public  int Id { get; set; }

        public string Nom { get; set; }

        public bool ConnaissanceAcquise{ get; set; }

        //utile plus tard pour faire un pourcentage 
        public  int NiveauConnaissance = new {1,2,3,4};

        public List<string> UrlDoc { get; set; }
        
        public string Version { get; set; }


    }
}