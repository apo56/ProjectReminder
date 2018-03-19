using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsProjets
{
    class Bricolage : Projets
    {
        //possiblité de rajouter une list
        public List<Outil> Outils{ get; set; }

        public List<Matériaux> Matériaux { get; set; }

        public int Prix { get; set; }
        

    }
}
