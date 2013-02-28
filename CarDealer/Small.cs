﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Small : Car
    {
        public Small(string colour, string model, int price, string state)
            : base (colour, model, price, state)
        {

        }
        public Small()
        {
               
        }

        public override string ToString()
        {
            return ("***Car-Small***" + "\nModel: " + this.Model + "\nColour: " + this.Colour + "\nPrice: " + this.Price + "\nState: " + this.State + "\n***");
        }
    }
}
