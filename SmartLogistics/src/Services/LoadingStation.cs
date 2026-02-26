using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SmartLogistics.src.Enums;
using SmartLogistics.src.Interfaces;
using SmartLogistics.src.Items;

namespace SmartLogistics.src.Services
{
    public class LoadingStation
    {
         
        public double LoadingMath(List<Freight> fracht)
        {
            double weight = 0;
            foreach (var palette in fracht)
            {
                weight += palette.Weight;
            }
            return weight;
        }
        
    }
}
