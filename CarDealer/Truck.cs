﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Truck : Vehicle
    {
        public Truck(string colour, string model, int price, string state, string licensePlate)
            : base (colour, model, price, state, licensePlate)
        {

        }
        public Truck()
        {
               
        }

        public override string ToString()
        {
            return ("-----Truck-----\n" + base.ToString());
        }
    }
}
