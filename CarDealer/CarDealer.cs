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
        /// TODO: Add the Customer list too
        /// </summary>
        /// <remarks>Vehicle's toString</remarks>
        public override string ToString()
        {
            string result= string.Join("\n\n", this.vehicleList);

            return result;
        }
    }
}
