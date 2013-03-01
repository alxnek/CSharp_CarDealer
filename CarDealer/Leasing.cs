using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace CarDealerLibraries
{
    public class Leasing
    {

        private IFormatter formatter;
        private Stream stream;
        private Truck truck;
        private string nameOfContract;

        /// <summary>
        /// Create a lease
        /// </summary>
        /// <remarks>Business and a truck</remarks>
        public Leasing()
        {
            throw new System.NotImplementedException();
        }
        //private string leaseName="file";

        /// <summary>
        /// Save the lease into a binary serialized file
        /// </summary>
        /// <remarks>IO</remarks>
        public void SaveLease(Truck vehicle)
        {
            //ask in the GUI for the string information of the lease
            //ask for the name of the binary file
            //save the bin file
        }

        /// <summary>
        /// Load an existing lease
        /// </summary>
        /// <remarks>IO</remarks>
        public void LoadLease()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Print the lease
        /// </summary>
        /// <remarks>IO</remarks>
        public void PrintLease()
        {
            throw new System.NotImplementedException();
        }
    }
}
