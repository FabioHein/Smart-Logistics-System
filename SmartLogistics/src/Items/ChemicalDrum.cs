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

        public ChemicalDrum(string id, double weight) : base(id , weight)
        {
        }

        public void CheckTemperature()
        {
            Console.WriteLine($"Die Temperatur wurde geprüft.");
        }
    }
}
