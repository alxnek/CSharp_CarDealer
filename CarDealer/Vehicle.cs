using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    public class Vehicle
    {
        protected string colour;
        protected string model;
        protected int price;
        protected Enum state;
         
        /// <summary>
        /// The vehicle's Price
        /// </summary>
        /// <remarks>It can`t be negative</remarks>
        protected int Price
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
        protected string Model
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
        protected string Colour
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
        protected Enum State
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
        public string toString()
        {
            throw new System.NotImplementedException();
        }
    }
}
