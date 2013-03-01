using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    public class Customer
    {
        private string address;
        private int phone;

        /// <summary>
        /// Create a customer
        /// </summary>
        /// <remarks>customer</remarks>
        public Customer(string address, int phone)
        {
            this.address = address;
            this.phone = phone;
        }

        /// <summary>
        /// Get/Set fields
        /// </summary>
        /// <remarks>get/set</remarks>
        public string Address
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Get/Set phone
        /// </summary>
        /// <remarks>get/set</remarks>
        public int Phone
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
