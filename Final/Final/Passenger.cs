using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class Passenger
    {
        string Name;
        double Weight;

        public Passenger(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            return this.Weight;
        }
    }
}
