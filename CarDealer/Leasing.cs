using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarDealerLibraries
{
    public class Leasing
    {

        private IFormatter formatter;
        private Stream stream;
        private Truck truck;
        private string contractName;

        /// <summary>
        /// Create a lease
        /// </summary>
        /// <remarks>Business and a truck</remarks>
        public Leasing(Truck truck, string contractName)
        {
            this.formatter = new BinaryFormatter();
            this.truck = truck;
            this.contractName = contractName;
        }


        /// <summary>
        /// Save the lease into a binary serialized file
        /// </summary>
        /// <remarks>IO</remarks>
        public void SaveLease(Truck vehicle)
        {
            //ask in the GUI for the string information of the lease
            //ask for the name of the binary file
            //save the bin file
            this.stream = new FileStream(this.contractName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.truck);
            stream.Close();
        }

        /// <summary>
        /// Load an existing lease
        /// </summary>
        /// <remarks>IO</remarks>
        public static Leasing LoadLease(string nameOfContract)
        {
            nameOfContract += ".bin";
            Stream stream = new FileStream(nameOfContract, FileMode.Open, FileAccess.Read, FileShare.Read);
            IFormatter formatter = new BinaryFormatter();

            Truck truckOfLeasing = (Truck)formatter.Deserialize(stream);
            stream.Close();

            return new Leasing(truckOfLeasing, nameOfContract);
        }

        /// <summary>
        /// Print the lease
        /// </summary>
        /// <remarks>IO</remarks>
        public void PrintLease()
        {
            //Change to show it in GUI
            Console.Out.WriteLine("CONTRACT NAME: " + this.contractName + "\n" + this.truck.ToString());
        }
    }
}
