using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BO;

namespace ProjectReminder.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Projet> Projet { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Note> Note { get; set; }
    }
}