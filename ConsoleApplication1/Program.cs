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
                //2 lists
                List<Vehicle> veh_list = new List<Vehicle>();
                List<Customer> cust_list = new List<Customer>();
                //create cars and customers
                Car c = new Car("Ford", "Fiesta", 12000, "sold");
                Truck t = new Truck("Mercedes", "truck5000", 112000, "sold");
                Car l = new Large("Mercedes", "E270", 62000, "sold");
                Car s = new Small("Mini", "mini", 32000, "sold");
                Private pri_cust = new Private("address", 123123123, "Gangbang", "age", "yes");
                Business bus_cust = new Business("address", 4444444, 1001001, 555555, "MR Coder", "Even god code SA");

          //      Console.Out.WriteLine("TEST SERIALIZABLE");
          //      IFormatter formatter = new BinaryFormatter();
          //      Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
          //      formatter.Serialize(stream, c);
          //      formatter.Serialize(stream, pri_cust);
          //      stream.Close();
          //      //Once the file.bin is created you can load it again with
          //      Stream streamToRead = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
          //      Vehicle myFordFiesta = (Vehicle)formatter.Deserialize(streamToRead);
          //      streamToRead.Close();
          //      load the fiesta.bin in the folder project
          //      Contract.LoadContract("fiesta").PrintContract();
                             
                //make the cardealer
                CarDealer CD = new CarDealer(veh_list, cust_list);

                //How to work with de CARDEALER without touching any list
              //  CD.AddCustomer(pri_cust);
                CD.AddVehicle(t);
                CD.AddVehicle(s);
                CD.AddVehicle(c);

              // No customer and no truck
              // CD.DeleteVehicle(t);
              // CD.DeleteCustomer(pri_cust);

                Console.Out.WriteLine("CARDEALER TOSTRING_______\n" + CD.ToString());

                Contract contract = new Contract(s, "contractForSmall");
                Contract contract2 = new Contract(c, "contractForCar");

                pri_cust.AddContract(contract);
                pri_cust.AddContract(contract2);
                
                //New private cus with contracts
                CD.AddCustomer(pri_cust);

                Leasing lease = new Leasing(t,"serious truck business",3000, "2 years");
                bus_cust.AddLease(lease);

                CD.AddCustomer(bus_cust);

                //Mambo of toStrings
                Console.Out.WriteLine("CARDEALER TOSTRING_______\n" + CD.ToString());          

                Console.Clear();

                //Save all the stuff in files
                CD.SaveVehiclesToFile();
                CD.SaveCustomersToFile();

                //Load stuff in new object
                CarDealer CD_DeserializedStuff = new CarDealer(new List<Vehicle>(), new List<Customer>());
                CD_DeserializedStuff.VehicleList = CD.LoadVehicles();
                CD_DeserializedStuff.CustomerList = CD.LoadCustomers();
                Console.Out.WriteLine(CD_DeserializedStuff.ToString());

                Console.In.ReadLine();
            }
        }
    }
}
