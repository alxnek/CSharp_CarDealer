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
    public class Leasing
    {

        //private IFormatter formatter;
        //private Stream stream;

        private Truck truck;
        private string leaseName;
        private int rentPerMonth;
        private string rentPeriod;
        private string date = DateTime.Now.ToShortDateString();
        /// <summary>
        /// Create a lease
        /// </summary>
        /// <remarks>Business and a truck</remarks>
        public Leasing(Truck truck, string leaseName, int rent, string rentPeriod)
        {
            //this.formatter = new BinaryFormatter();

            this.truck = truck;
            this.leaseName = leaseName;
            this.rentPerMonth = rent;
            this.rentPeriod = rentPeriod;
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
            //this.stream = new FileStream(this.leaseName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream, this.truck);
            //stream.Close();
        }

        /// <summary>
        /// LoadCustomers an existing lease
        /// </summary>
        /// <remarks>IO</remarks>
        //public static Leasing LoadLease(string nameOfContract)
        //{
        //    nameOfContract += ".bin";
        //    Stream stream = new FileStream(nameOfContract, FileMode.Open, FileAccess.Read, FileShare.Read);
        //    IFormatter formatter = new BinaryFormatter();

        //    Truck truckOfLeasing = (Truck)formatter.Deserialize(stream);
        //    stream.Close();

        //    return new Leasing(truckOfLeasing, nameOfContract);
        //}

        /// <summary>
        /// Print the lease
        /// </summary>
        /// <remarks>IO</remarks>
        public override string ToString()
        {
            //Change to show it in GUI
            return ("\nLEASE NAME: " + this.leaseName + "\nRent per month: " + this.rentPerMonth + "\nRent period: " +this.rentPeriod+ "\n" + this.truck.ToString() + "\nStart date----> " + this.date + "\n___________________________");
        }
    }
}
