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

        public Contract(Vehicle vehicle)
        {
            this.vehicle = vehicle;
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
            String contractName = "myContract.bin";
            this.formatter = new BinaryFormatter();
            this.stream = new FileStream(contractName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.vehicle);
            stream.Close();
        }

        /// <summary>
        /// Load an existing contract
        /// </summary>
        /// <remarks>IO</remarks>
        public void LoadContract()
        {
            throw new System.NotImplementedException();
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
