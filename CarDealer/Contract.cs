using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarDealerLibraries
{
    public class Contract
    {
        private IFormatter formatter;
        private Stream stream;
        private Vehicle vehicle;
        private string contractName;

        /// <summary>
        /// Contract constructor
        /// </summary>
        /// <remarks>Needs a vehicle and a name for the contract</remarks>
        public Contract(Vehicle vehicle, string contractName)
        {
            this.formatter = new BinaryFormatter();
            this.vehicle = vehicle;
            this.contractName = contractName;

        }

        /// <summary>
        /// Save the contract into a binary serialized file
        /// </summary>
        /// <remarks>IO</remarks>
        public void SaveContract()
        {
            //ask in the GUI for the string information of the contract
            //ask for the name of the binary file
            //save the bin file
            
            this.stream = new FileStream(this.contractName+".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.vehicle);
            stream.Close();
        }

        /// <summary>
        /// Load an existing contract from his name
        /// </summary>
        /// <remarks>Static access!</remarks>
        public static Contract LoadContract(string nameOfContract)
        {
            nameOfContract += ".bin";
            Stream stream = new FileStream(nameOfContract, FileMode.Open, FileAccess.Read, FileShare.Read);
            IFormatter formatter = new BinaryFormatter();

            Vehicle carOfContract = (Vehicle)formatter.Deserialize(stream);
            stream.Close();

            return new Contract(carOfContract, nameOfContract);
        }

        /// <summary>
        /// Print the contract in the console
        /// </summary>
        /// <remarks>IO</remarks>
        public void PrintContract()
        {
            //Change to show it in GUI
            Console.Out.WriteLine("CONTRACT NAME: " + this.contractName + "\n" + this.vehicle.ToString());
        }
    }
}
