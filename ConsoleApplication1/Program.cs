using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CarDealerLibraries;//With this is not needed to use CarDealerLibraries.----- thx

/*Added a reference to the DLL from the CarDealer project.
 * 
 * Use that stuff with CarDealerLibraries. ------ :)
 * 
 * Build CarDealer then Debug this project to test the CarDealer
 * 
 * */
namespace ConsoleApplication1
{
    class Program
    {
        class TestVehicles
        {
            static void Main(string[] args)
            {

                //2 lists
                List<CarDealerLibraries.Vehicle> veh_list = new List<CarDealerLibraries.Vehicle>();
                List<CarDealerLibraries.Customer> cust_list = new List<CarDealerLibraries.Customer>();
                //create cars and customers
                CarDealerLibraries.Car c = new CarDealerLibraries.Car("Ford", "Fiesta", 12000, "sold");
                CarDealerLibraries.Truck t = new CarDealerLibraries.Truck("Mercedes", "truck5000", 112000, "sold");
                CarDealerLibraries.Car l = new CarDealerLibraries.Large("Mercedes", "E270", 62000, "sold");
                CarDealerLibraries.Car s = new CarDealerLibraries.Small("Mini", "mini", 32000, "sold");
                CarDealerLibraries.Private pri_cust = new CarDealerLibraries.Private("address", 123123123, "Gangbang", "age", "yes");
                Business bus_cust = new Business("address", 4444444, 1001001, 555555, "MR Coder", "Even god code SA");

                //make the cardealer
                CarDealerLibraries.CarDealer CD = new CarDealerLibraries.CarDealer(veh_list, cust_list);

                //How to work with de CARDEALER without touching any list
    
                CD.AddVehicle(t);
                CD.AddVehicle(s);
                CD.AddVehicle(c);

                Console.Out.WriteLine("CARDEALER TOSTRING_______\n" + CD.ToString());

                Contract contract = new Contract(s, "contractForSmall");
                Contract contract2 = new Contract(c, "contractForCar");                
                pri_cust.AddContract(contract);
                pri_cust.AddContract(contract2);
                //New private cus with 2 contracts
                CD.AddCustomer(pri_cust);

                Leasing lease = new Leasing(t,"serious truck business",3000, "2 years");
                bus_cust.AddLease(lease);
                CD.AddCustomer(bus_cust);

                //Mambo of toStrings
                Console.Out.WriteLine("CARDEALER TOSTRING_______\n" + CD.ToString());                      
               
                Console.Clear();

                //THIS works!
                //CD.DeleteCustomer(bus_cust);

                //Save all the stuff in files
                CD.SaveVehiclesToFile();
                CD.SaveCustomersToFile();
                //Load stuff in new object
                CarDealer CD_DeserializedStuff = new CarDealer(new List<Vehicle>(), new List<Customer>());
                CD_DeserializedStuff.VehicleList = CD.LoadVehicles();
                CD_DeserializedStuff.CustomerList = CD.LoadCustomers();
                Console.Out.WriteLine(CD_DeserializedStuff.ToString());

                Console.Clear();
              
                //THIS NOT!!!! :(
                CD_DeserializedStuff.DeleteCustomer(bus_cust);
                Console.Out.WriteLine(CD_DeserializedStuff.ToString());
                Console.In.ReadLine();

            }
        }
    }
}
