using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BO
{
    [Table("Projets")]
    public class Projet
    {       
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public int Cout { get; set; }

        public virtual List<Note> Notes{ get; set; }

        public virtual Utilisateur Utilisateur{ get; set; }

        



    }
}
