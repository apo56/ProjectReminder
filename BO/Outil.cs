using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BO
{
    [Table("Outil")]
    public class Outil
    {
        public int Id  { get; set; }

        public string Nom{ get; set; }

        public double? Prix { get; set; }

        public bool PossedeOutil { get; set; }

    }
}
