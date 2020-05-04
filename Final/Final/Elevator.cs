using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class Elevator
    {
        double MaxWeight;
        Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            foreach (Passenger whoever in Occupants)
            {
                totalWeight += whoever.GetWeight();
            }

            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
    }


}
