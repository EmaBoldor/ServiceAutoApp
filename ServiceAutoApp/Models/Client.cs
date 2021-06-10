using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoApp.Models
{
    public class Client
    {
        public Guid ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Locatia { get; set; }
        public string TipDefectiune { get; set; }
        public string TipMasina { get; set; }
    }
}
