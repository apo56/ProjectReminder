﻿using System;
using System.Collections.Generic;
using System.Text;
using BO;

namespace ModelsProjets
{
    public class Bricolage : Projets
    {
        //possiblité de rajouter une list
        public List<Outil> ListOutilsNecessaires{ get; set; }

        public List<Matériaux> ListMatériaux { get; set; }

        
        

    }
}
