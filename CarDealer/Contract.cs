using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarDealerLibraries
{
    [Serializable]
    public class Contract
    {
        private IFormatter formatter;
        private Stream stream;        

        private Car car;
        private string contractName;
        private string date = DateTime.Now.ToShortDateString();

        /// <summary>
        /// Makes a contract for a customer
        /// </summary>
        /// <remarks>Needs a vehicle and a name for the contract</remarks>
        public Contract(Car car, string contractName)
        {
            this.formatter = new BinaryFormatter();
            this.car = car;
            this.contractName = contractName;           

        }

        public Contract()
        {
            // TODO: Complete member initialization
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
            formatter.Serialize(stream, this.car);
            stream.Close();
        }

        /// <summary>
        /// LoadCustomers an existing contract from his name
        /// </summary>
        /// <remarks>Static access!</remarks>
        public static Contract LoadContract(string nameOfContract)
        {
            nameOfContract += ".bin";
            Stream stream = new FileStream(nameOfContract, FileMode.Open, FileAccess.Read, FileShare.Read);
            IFormatter formatter = new BinaryFormatter();

            Car carOfContract = (Car)formatter.Deserialize(stream);
            stream.Close();

            return new Contract(carOfContract, nameOfContract);
        }

        /// <summary>
        /// Get the String with info about the contract
        /// </summary>
        /// <remarks>IO</remarks>
        public override String ToString()
        {
            //Change to show it in GUI
            return ("\nCONTRACT NAME: " + this.contractName + "\n" + this.car.ToString()+ "\nDate----> "+ this.date+"\n___________________________");
        }
    }
}
