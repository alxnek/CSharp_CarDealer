using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                CarDealerLibraries.Vehicle v = new CarDealerLibraries.
                    Car("Ford", "Fiesta", 12000, "sold");

                CarDealerLibraries.Vehicle t = new CarDealerLibraries.
                    Truck("Mercedes", "truck5000", 112000, "sold");
               Console.Out.WriteLine(v.ToString());
               Console.Out.WriteLine(t.ToString());
               Console.In.ReadLine();

            }
        }
    }
}
