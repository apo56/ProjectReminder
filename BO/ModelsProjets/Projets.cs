using System;
using System.Collections.Generic;

namespace ModelsProjets
{
    public class Projets
    {
        public Projets()
        {

        }

        public Projets(int id, string nom, string type, List<Projets> projets, int cout)
        {
            Id = id;
            Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            Type = type ?? throw new ArgumentNullException(nameof(type));
            this.projets = projets ?? throw new ArgumentNullException(nameof(projets));
            Cout = cout;
        }

        public int Id { get; set; }

        public string Nom { get; set; }

        public String Type { get; set; }

        public List<Projets> projets { get; set; }

        public int Cout{ get; set; }




    }
}
