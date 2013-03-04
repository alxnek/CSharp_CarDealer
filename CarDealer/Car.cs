using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Car : Vehicle
    {
        public Car(string colour, string model, int price, string state, string licensePlate)
            : base (colour, model, price, state, licensePlate)
        {

        }
        public Car()
        {
               
        }

        public override string ToString()
        {
            return ("-----Car-----\n"+base.ToString());
        }
    }
}
