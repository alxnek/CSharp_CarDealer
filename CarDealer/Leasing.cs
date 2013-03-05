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

        private Truck truck;
        private string leaseName;
        private int rentPerMonth;
        private string rentPeriod;
        private string date = DateTime.Now.ToShortDateString();
        /// <summary>
        /// Create a lease
        /// </summary>
        /// <remarks>Business and a truck</remarks>
        

        // add rentperiod logic, atm it accepts a string, but it needs to do calculations on start to end date.
        public Leasing(Truck truck, string leaseName, int rent, string rentPeriod)
        {
            //this.formatter = new BinaryFormatter();

            this.truck = truck;
            this.leaseName = leaseName;
            this.rentPerMonth = rent;
            this.rentPeriod = rentPeriod;
        }

        /// <summary>
        /// Print the lease
        /// </summary>
        /// <remarks>IO</remarks>
        public override string ToString()
        {
            return ("\nLEASE NAME: " + this.leaseName + "\nRent per month: " + this.rentPerMonth + "\nRent period: " +this.rentPeriod+ "\n" + this.truck.ToString() + "\nStart date----> " + this.date + "\n___________________________");
        }
    }
}
