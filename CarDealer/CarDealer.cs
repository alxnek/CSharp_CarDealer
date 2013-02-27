using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    //New branch
    public class CarDealer
    {
        private List<Vehicle> vehicleList;
        // Add CustomerList

        public CarDealer(List<Vehicle> vehicleList)
        {
            this.vehicleList = vehicleList;
        }

        public CarDealer()
        {

        }

        public Vehicle Vehicle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Add vehicle to the List
        /// </summary>
        /// <remarks>Vehicle Class</remarks>
        public void AddVehicle(Vehicle vehicle)
        {
            this.vehicleList.Add(vehicle);
        }

        /// <summary>
        /// Convert the vehicle's properties into text
        /// </summary>
        /// <remarks>Vehicle's toString</remarks>
        public override string ToString()
        {
            string result="";

            for (int i = 0; i < this.vehicleList.Capacity; i++)
            {
                result = result + this.vehicleList[i].ToString();
            }
            return result;
        }
    }
}
