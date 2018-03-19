using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectReminder.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Projet> projets { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Note> notes { get; set; }
    }
}