using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    public class Vehicle
    {
        private string colour;
        private string model;
        private int price;
        private string state;

        public Vehicle(string colour, string model, int price, string state)
        {
            this.colour = colour;
            this.model = model;
            this.price = price;
            this.state = state;
                
        }

        public Vehicle()
        {
                
        }
        /// <summary>
        /// The vehicle's Price
        /// </summary>
        /// <remarks>It can`t be negative</remarks>
        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        /// <summary>
        /// The vehicle's Model
        /// </summary>
        /// <remarks>String of the car's Model can contain numbers too</remarks>
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        /// <summary>
        /// The car's Colour
        /// </summary>
        /// <remarks>Shouldn't contain numbers</remarks>
        public string Colour
        {
            get
            {
                return this.colour;
            }
            set
            {
                this.colour = value;
            }
        }

        /// <summary>
        /// The car's State
        /// </summary>
        /// <remarks>[Commission, sold, leased]</remarks>
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// Convert the vehicle's properties into text
        /// </summary>
        /// <remarks>Vehicle's toString</remarks>
        public override string ToString() 
        {
            return ("Model: " + this.Model + "Colour: " + this.Colour + "Price: " + this.Price + "State: " + this.State);
        }
    }
}
