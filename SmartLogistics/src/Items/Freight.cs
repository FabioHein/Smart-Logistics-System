using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogistics.src.Items
{
    public abstract class Freight
    {
        private double _weight;
        private string _id;

        public double Weight { get { return _weight; } }
        public string Id { get { return _id; } }

        public Freight(string id, double weight)
        {
            _id = id;
            _weight = weight;
        }
    }
}
