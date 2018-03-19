using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectReminder
{
    [Table("Projets")]
    public class Projet
    {
        public Projet()
        {

        }
        public Projet(int id, string nom, TypeProjet type, string description, List<Note> notes, Utilisateur utilisateur, int cout)
        {
            Id = id;
            Nom = nom;
            Typeprojets = type;
            Description = description;
            this.notes = notes;
            this.utilisateur = utilisateur;
            Cout = cout;
        }

        public int Id { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public virtual List<Note> notes{ get; set; }

        public virtual Utilisateur utilisateur{ get; set; }

        public int Cout{ get; set; }




    }
}
