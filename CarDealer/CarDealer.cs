using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{

    public class CarDealer
    {
        private List<Vehicle> vehicleList;
        private List<Customer> customerList;
        //Add if needed some serialization for the whole list

        public CarDealer(List<Vehicle> vehicleList, List<Customer> customerList)
        {
            this.vehicleList = vehicleList;
            this.customerList = customerList;
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
        /// Add customer to the List
        /// </summary>
        /// <remarks>Customer Class</remarks>
        public void AddCustomer(Customer c)
        {
            this.customerList.Add(c);
        }



        /// <summary>
        /// Delete a vehicle from the list
        /// </summary>
        /// <remarks>Delete</remarks>
        public void DeleteVehicle(Vehicle vehicle)
        {
            this.vehicleList.Remove(vehicle);
        }

        /// <summary>
        /// Delete a customer from the list
        /// </summary>
        /// <remarks>Delete</remarks>
        public void DeleteCustomer(Customer c)
        {
            this.customerList.Remove(c);
        }

        /// <summary>
        /// Convert the vehicle's and Customer properties into text        
        /// </summary>
        /// <remarks>CarDealer's toString</remarks>
        public override string ToString()
        {
            string result = string.Join("\n\n", this.vehicleList);
            result += string.Join("\n\n", this.customerList);

            return result;
        }
    }
}
