using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ElementModel
    {
        public int AtomicNumber { get; set; }

        public string AtomicSymbol { get; set; }

        public string AtomicName { get; set; }

        public double AtomicMass { get; set; }
        
        public double MeltingPoint { get; set; }

        public double BoilingPoint { get; set; }

        public double Density { get; set; }

        public double ElectroNegativity { get; set; }
    }
}