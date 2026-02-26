using SmartLogistics.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogistics.src.Items
{
    public class SteelBeam : Freight, IHeavyLoad
    {
        public SteelBeam(string id, double weight) : base( id, weight)
        {
        }

        public override void GetLoadingInstruction()
        {
            Console.WriteLine($"Der Stahlträger {Id} muss liegend Transportiert werden.");
        }

        
        public void SecureWithChains()
        {
            Console.WriteLine($"Der Stahlträger {Id}, wird mit Ketten gesichert.");
        }
    }
}
