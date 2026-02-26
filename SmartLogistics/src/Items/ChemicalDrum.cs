using System;
using System.Collections.Generic;
using System.Text;
using SmartLogistics.src.Enums;
using SmartLogistics.src.Interfaces;
using SmartLogistics.src.Items;

namespace SmartLogistics.src.Items
{
    public class ChemicalDrum : Freight, IRefrigerated
    {

       private HazardClass _hazard;

        public ChemicalDrum(string id, double weight, HazardClass hazard) : base(id , weight)
        {
            _hazard = hazard;
        }

        public override void GetLoadingInstruction()
        {
            Console.WriteLine($"Das Fass {Id} muss stehend Transportiert werden.");
        }

        public void CheckTemperature()
        {
            Console.WriteLine($"Fass {Id}: Kühlung Stabil.");
        }
    }
}
