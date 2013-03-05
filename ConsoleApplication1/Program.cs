using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CarDealerLibraries;//makes car, truck and other objects recognizeable without using the cardealer prefix

/*Added a reference to the DLL from the CarDealer project.
 * 
 * Use that stuff with CarDealerLibraries. ------ :)
 * 
 * Build CarDealer then Debug this project to test the CarDealer
 * 
 * */
namespace ConsoleApplication15
{
    class Program
    {
        class TestVehicles
        {
            static void Main(string[] args)
            {
                //1- 2 lists
                List<Vehicle> veh_list = new List<Vehicle>();
                List<Customer> cust_list = new List<Customer>();
                //2- CarDealer with empty list
                CarDealer CD = new CarDealer(veh_list, cust_list);

                //3 customers
                Private pri_cust = new Private("address", 123123123, "Gangbang", "age", "yes");
                Business bus_cust = new Business("address", 4444444, 1001001, 555555, "MR Coder", "Even god code SA");          //Add customers
                CD.AddCustomer(pri_cust);
                CD.AddCustomer(bus_cust);

                //4 create cars 
                Car c = new Car("Ford", "Fiesta", 12000, "sold","111");
                Truck t = new Truck("Mercedes", "truck5000", 112000, "sold", "222");
                //add vehicles
                CD.AddVehicle(c);
                CD.AddVehicle(t);                

                //6 Create a contract              
                Contract contract2 = new Contract(c, "contractForCar");             
                //7 Select customer and add the contract to him
                pri_cust.AddContract(contract2);                             
                //Or a lease
                Leasing lease = new Leasing(t, "serious truck business", 3000, "2 years");
                bus_cust.AddLease(lease);   
   
                //8 Save all the stuff in files
                CD.SaveVehiclesToFile();
                CD.SaveCustomersToFile();

                //9 Load stuff in new object
                CarDealer CD_DeserializedStuff = new CarDealer(new List<Vehicle>(), new List<Customer>());
                CD_DeserializedStuff.VehicleList = CD.LoadVehicles();
                CD_DeserializedStuff.CustomerList = CD.LoadCustomers();
                Console.Out.WriteLine(CD_DeserializedStuff.ToString());

                Console.In.ReadLine();
            }
        }

        
    }
}
