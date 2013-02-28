using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Car : Vehicle
    {
        public Car(string colour, string model, int price, string state)
            : base (colour, model, price, state)
        {

        }
        public Car()
        {
               
        }

        public override string ToString()
        {
            return ("***Car***" + "\nModel: " + this.Model + "\nColour: " + this.Colour + "\nPrice: " + this.Price + "\nState: " + this.State + "\n***");
        }
    }
}
