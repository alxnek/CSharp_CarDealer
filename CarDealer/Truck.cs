using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    public class Truck : Vehicle
    {
        public Truck(string colour, string model, int price, string state)
            : base (colour, model, price, state)
        {

        }
        public Truck()
        {
               
        }
    }
}
