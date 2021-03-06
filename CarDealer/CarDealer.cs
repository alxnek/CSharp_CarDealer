﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CarDealerLibraries
{
    public class CarDealer
    {
        private List<Vehicle> vehicleList;

        private List<Customer> customerList;
        private Stream stream, streamC;

        [field: NonSerializedAttribute()]
        private BinaryFormatter formatter;


        public CarDealer(List<Vehicle> vehicleList, List<Customer> customerList)
        {

            this.vehicleList = vehicleList;
            this.customerList = customerList;
        }

        public CarDealer()
        {
        }

        /// <summary>
        /// Customer's list
        /// </summary>
        /// <remarks>customers</remarks>
        public List<Customer> CustomerList
        {
            get
            {
                return this.customerList;
            }
            set
            {
                this.customerList = value;
            }
        }

        /// <summary>
        /// Vehicle's list
        /// </summary>
        /// <remarks>vehicles</remarks>
        public List<Vehicle> VehicleList
        {
            get
            {
                return this.vehicleList;
            }
            set
            {
                this.vehicleList = value;
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
        public void DeleteVehicle(string licensePlate)
        {
            Vehicle veh_tofind = this.vehicleList.Find(
                 delegate(Vehicle veh)
                 {
                     return veh.LicensePlate == licensePlate;
                 }
                );
            if (veh_tofind != null)
            {
                //Console.Out.WriteLine(cus_tofind.ToString() + "\n This customer was Find by ID: " + addressToFind);
                this.vehicleList.Remove(veh_tofind);
            }
            else
            {
                Console.Out.WriteLine("\nCannot delete 'the license plate doesn't exist': {0}\n", licensePlate);
            }
        }

        /// <summary>
        /// Delete a customer from the list by his address
        /// </summary>
        /// <remarks>Delete</remarks>
        public void DeleteCustomer(String addressToFind)//Customer c)
        {
            Customer cus_tofind = this.customerList.Find(
                 delegate(Customer cus)
                 {
                     return cus.Address == addressToFind;
                 }
                );
            if (cus_tofind != null)
            {
                
                this.customerList.Remove(cus_tofind);
            }
            else
            {
                Console.Out.WriteLine("\nCannot delete 'Wrong address': {0}\n", addressToFind);
            }

        }

        /// <summary>
        /// Convert the vehicle's and Customer properties into text        
        /// </summary>
        /// <remarks>CarDealer's toString</remarks>
        public override string ToString()
        {
            string result = "";
            try
            {
                //result = string.Join("\n\n", this.vehicleList);
                result += string.Join("\n\n", this.customerList);

            }
            catch (Exception e)
            {
                Console.Out.Write(e.Message);
            }
            return result;
        }

        /// <summary>
        /// Save all the vehicles in a file
        /// </summary>
        /// <remarks>.bin file in bin/Release</remarks>
        public void SaveVehiclesToFile()
        {
            this.formatter = new BinaryFormatter();
            this.stream = new FileStream("Vehicles.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            this.formatter.Serialize(this.stream, this.vehicleList);
            this.stream.Close();
        }

        /// <summary>
        /// Save all customers in a file
        /// </summary>
        /// <remarks>.bin file in bin/Release</remarks>
        public void SaveCustomersToFile()
        {

            this.formatter = new BinaryFormatter();

            this.streamC = new FileStream("Customers.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            this.formatter.Serialize(this.streamC, this.customerList);
            this.streamC.Close();


        }

        /// <summary>
        /// Load customer from file
        /// </summary>
        /// <remarks>serialization</remarks>
        public List<Customer> LoadCustomers()
        {
            try
            {
                this.formatter = new BinaryFormatter();
                this.streamC = new FileStream("Customers.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Customer> deserializedList = (List<Customer>)this.formatter.Deserialize(this.streamC);
                streamC.Close();
                return deserializedList;
            }
            catch (Exception e){

                Console.Out.WriteLine(e.Message);
            }

            return new List<Customer>();
        }

        /// <summary>
        /// Load vehicles from a file
        /// </summary>
        /// <remarks>Serialization</remarks>
        public List<Vehicle> LoadVehicles()
        //public void LoadVehicles()
        {
            try
            {
                this.formatter = new BinaryFormatter();
                this.stream = new FileStream("Vehicles.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Vehicle> deserializedList = (List<Vehicle>)this.formatter.Deserialize(this.stream);
                stream.Close();

                return deserializedList;
            }
            catch(Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            return new List<Vehicle>();
        }
    }
}
