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
    }
}
