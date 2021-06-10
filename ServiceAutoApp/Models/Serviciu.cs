using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoApp.Models
{
    public class Serviciu
    {
        public Guid ID { get; set; }
        public string DenumireServiciu { get; set; }
        public double Pret { get; set; }
        public string TipMasinaNecesara { get; set; }
    }
}
