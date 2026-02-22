using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogistics.src.Items
{
    public abstract class Freight
    {
        private double _weight;
        private string _id;

        public double Weight { get { return _weight; } set { _weight = value; } }
        public string Id { get { return _id; } set { _id = value; } }

        public Freight(string id, double weight)
        {
            Id = id;
            Weight = weight;
        }
    }
}
