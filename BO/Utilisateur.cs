using System.Collections.Generic;

namespace BO
{
    [Table("Utilisateurs")]
    public class Utilisateur
    {

        public int Id   { get; set; }

        public string Nom { get; set; }

        public string Prenom{ get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        //utile pour les connaissances
        public List<string> ListLanguesConnues { get; set; } 

        public virtual List<Projet> Projets { get; set; }

        public virtual List<Outil> MesOutils { get; set; }

        public virtual List<Connaissance> MesConnaissances { get; set; }



    }
}