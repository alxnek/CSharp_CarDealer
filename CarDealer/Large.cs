using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Large : Car
    {
        public Large(string colour, string model, int price, string state)
            : base (colour, model, price, state)
        {

        }
        public Large()
        {
               
        }
        public override string ToString()
        {
            return ("***Car-Large***" + "\nModel: " + this.Model + "\nColour: " + this.Colour + "\nPrice: " + this.Price + "\nState: " + this.State + "\n***");
        }
    }
}
