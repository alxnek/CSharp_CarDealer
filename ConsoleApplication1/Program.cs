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

          //      Console.Out.WriteLine("TEST SERIALIZABLE");
          //      IFormatter formatter = new BinaryFormatter();
          //      Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
          //      formatter.Serialize(stream, c);
          ////      formatter.Serialize(stream, pri_cust);
          //      stream.Close();
          //      //Once the file.bin is created you can load it again with
          //      Stream streamToRead = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
          //      Vehicle myFordFiesta = (Vehicle)formatter.Deserialize(streamToRead);
          //      streamToRead.Close();
                //load the fiesta.bin in the folder project
               // CarDealerLibraries.Contract.LoadContract("fiesta").PrintContract();

                
                //make the cardealer
                CarDealerLibraries.CarDealer CD = new CarDealerLibraries.CarDealer(veh_list, cust_list);

                //How to work with de CARDEALER without touching any list
                CD.AddCustomer(pri_cust);
                CD.AddVehicle(t);
                CD.AddVehicle(s);
                CD.AddVehicle(c);

                //No customer and no truck
                //CD.DeleteVehicle(t);
                CD.DeleteCustomer(pri_cust);

                Console.Out.WriteLine("CARDEALER TOSTRING_______\n" + CD.ToString());

                Contract contract = new Contract(s, "contractForSmall");
                Contract contract2 = new Contract(c, "contractForCar");
                contract.SaveContract();
                contract2.SaveContract();
                pri_cust.AddContract(contract);
                pri_cust.AddContract(contract2);

                //New customer with contracts
                CD.AddCustomer(pri_cust);

                CD.AddCustomer(bus_cust);

                //Mambo of toStrings
                Console.Out.WriteLine("CARDEALER TOSTRING_______\n" + CD.ToString());



                Console.In.ReadLine();

            }
        }
    }
}
