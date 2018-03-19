using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectReminder
{
    [Table("Utilisateurs")]
    public class Utilisateur
    {

        public int Id   { get; set; }

        public string Nom { get; set; }

        public string Prenom{ get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        public virtual List<Projet> projets { get; set; }

        public virtual List<Outil> MesOutils { get; set; }

        public virtual List<Connaissance> MesConnaissances { get; set; }


    }
}