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
        private DateTime? rent_start;
        private DateTime? rent_end;
        private string date = DateTime.Now.ToShortDateString();
        /// <summary>
        /// Create a lease
        /// </summary>
        /// <remarks>Business and a truck</remarks>
        

        // add rentperiod logic, atm it accepts a string, but it needs to do calculations on start to end date.
        public Leasing(Truck truck, string leaseName, int rent, DateTime? rent_start, DateTime? rent_end )
        {
            //this.formatter = new BinaryFormatter();
            this.truck = truck;
            this.leaseName = leaseName;
            this.rentPerMonth = rent;
            this.rent_start = rent_start;
            this.rent_end = rent_end;
        }

        /// <summary>
        /// Print the lease
        /// </summary>
        /// <remarks>IO</remarks>
        public override string ToString()
        {
            return ("\nRent per month: " + this.rentPerMonth + "\nRent Start: " + this.rent_start + "\nRent End: " + this.rent_end + "\nrent period in months: " + TotelMonthDifference() + "\n" + this.truck.ToString());
        }
        
        
        private string TotelMonthDifference()
        {
            DateTime dtOne = rent_start ?? DateTime.Now; //fixes issues with nullable datetime to datetime formats.
            DateTime dtTwo = rent_end ?? DateTime.Now;

            int intReturn = 0;
            dtOne = dtOne.Date.AddDays(-(dtOne.Day - 1));
            dtTwo = dtTwo.Date.AddDays(-(dtTwo.Day - 1));

            while (dtTwo.Date > dtOne.Date)
            {
                intReturn++;
                dtOne = dtOne.AddMonths(1);
            }

            return Convert.ToString(intReturn);
        }
    }

    
}
