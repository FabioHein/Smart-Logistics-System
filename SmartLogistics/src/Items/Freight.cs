using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogistics.src.Items
{
    public abstract class Freight
    {
        public double _weight { get; protected set; }
        public string _id { get; protected set; }

        public Freight(string id, double weight)
        {
            _id = id;
            _weight = weight;
        }
    }
}
