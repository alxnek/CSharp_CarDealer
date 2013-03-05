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

        private Car car;
        private string contractName;
        private string date = DateTime.Now.ToShortDateString();

        /// <summary>
        /// Makes a contract for a customer
        /// </summary>
        /// <remarks>Needs a vehicle and a name for the contract</remarks>
        public Contract(Car car, string contractName)
        {     
            this.car = car;
            this.contractName = contractName;       
        }

        public Contract()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// Get the String with info about the contract
        /// </summary>
        /// <remarks>IO</remarks>
        public override String ToString()
        {
            //Change to show it in GUI
            return ( this.car.ToString()+ "\nBuy Date: "+ this.date+"\n___________________________");
        }
    }
}
