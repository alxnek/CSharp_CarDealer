using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CarDealerLibraries;

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
                CarDealerLibraries.Vehicle c = new CarDealerLibraries.Car("Ford", "Fiesta", 12000, "sold");
                CarDealerLibraries.Vehicle t = new CarDealerLibraries.Truck("Mercedes", "truck5000", 112000, "sold");
                CarDealerLibraries.Vehicle l = new CarDealerLibraries.Large("Mercedes", "E270", 62000, "sold");
                CarDealerLibraries.Vehicle s = new CarDealerLibraries.Small("Mini", "mini", 32000, "sold");

                List<CarDealerLibraries.Vehicle> list = new List<CarDealerLibraries.Vehicle>();
                list.Add(c);
                list.Add(s);
                list.Add(l);
                list.Add(t);
                //CarDealerLibraries.CarDealer cdList = new CarDealerLibraries.CarDealer(list);
                //Console.Out.WriteLine(cdList.ToString());
                //cdList.DeleteVehicle(c);
                //Console.Out.WriteLine("Delete Fiesta\n" + cdList.ToString());

                Console.Out.WriteLine("TEST SERIALIZABLE");

                IFormatter formatter = new BinaryFormatter();
                //Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                //formatter.Serialize(stream, c);
                //stream.Close();

                //Once the file.bin is created you can load it again with
                //Stream streamToRead = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                //CarDealerLibraries.Vehicle myFordFiesta = (CarDealerLibraries.Vehicle)formatter.Deserialize(streamToRead);
                //streamToRead.Close();

                //Console.Out.WriteLine("TEST SERIALIZABLE OF FORD FIESTA----"+ myFordFiesta.Model);

                CarDealerLibraries.Contract contract = new CarDealerLibraries.Contract(c, "fiesta");
                contract.SaveContract();

                CarDealerLibraries.Contract.LoadContract("fiesta").PrintContract();


                Console.In.ReadLine();

            }
        }
    }
}
