using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BO
{
    public class Warrior
    {
        public int Id { get; set; }
        [Required, MaxLength(10), MinLength(5)]
        public string Titre { get; set; }

        [Required]
        [Display(Name = "Le blase")]
        public string NomPropre { get; set; }
        public Weapon Weapon { get; set; }
    }
}