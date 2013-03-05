using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Vehicle
    {
        private string colour;
        private string model;
        private int price;
        private string state;
        private string licensePlate;

        public Vehicle(string colour, string model, int price, string state, string licensePlate)
        {
            this.colour = colour;
            this.model = model;
            this.price = price;
            this.state = state;
            this.licensePlate = licensePlate;
                
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
        /// Car's licence plate
        /// </summary>
        /// <remarks>licence plate</remarks>
        public string LicensePlate
        {
            get
            {
                return this.licensePlate;
            }
            set
            {
                this.licensePlate = value;
            }
        }

        /// <summary>
        /// Convert the vehicle's properties into text
        /// </summary>
        /// <remarks>Vehicle's toString</remarks>
        public override string ToString() 
        {
            return ("Model: " + this.Model + "\nColour: " + this.Colour + "\nPrice: " + this.Price + "\nState: " + this.State+"\nPlate number: "+this.LicensePlate);
        }
    }
}
