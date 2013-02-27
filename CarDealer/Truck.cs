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

        public override string ToString()
        {
            return ("***Truck***" + "\nModel: " + this.Model + "\nColour: " + this.Colour + "\nPrice: " + this.Price + "\nState: " + this.State + "\n***");
        }
    }
}
