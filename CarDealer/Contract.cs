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

        public Contract(Vehicle vehicle, string contractName)
        {
            this.formatter = new BinaryFormatter();
            this.vehicle = vehicle;
            this.contractName = contractName+".bin";

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
            
            this.stream = new FileStream(this.contractName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.vehicle);
            stream.Close();
        }

        /// <summary>
        /// Load an existing contract
        /// </summary>
        /// <remarks>IO</remarks>
        public Contract LoadContract(string nameOfContract)
        {
            this.stream = new FileStream(nameOfContract, FileMode.Open, FileAccess.Read, FileShare.Read);
            Vehicle carOfContract = (Vehicle)formatter.Deserialize(this.stream);
            this.stream.Close();

            return new Contract(carOfContract, nameOfContract);
        }

        /// <summary>
        /// Print the contract
        /// </summary>
        /// <remarks>IO</remarks>
        public void PrintContract()
        {
            throw new System.NotImplementedException();
        }
    }
}
