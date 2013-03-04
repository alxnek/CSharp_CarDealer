using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Large : Car
    {
        public Large(string colour, string model, int price, string state, string licensePlate)
            : base (colour, model, price, state,licensePlate)
        {

        }
        public Large()
        {
               
        }
        public override string ToString()
        {
            return ("-----Large-----\n" + base.ToString());
        }
    }
}
