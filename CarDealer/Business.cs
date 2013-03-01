﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    public class Business : Customer
    {
        private int se_no;
        private int fax;
        private string contactPerson;
        private string companyName;
        /// <summary>
        /// Create a business customer
        /// </summary>
        /// <remarks>business</remarks>
        public Business(string address, int phone, int se_no, int fax, string contactPerson, string companyName):base(address,phone)
        {
            this.se_no = se_no;
            this.fax = fax;
            this.contactPerson = contactPerson;
            this.companyName = companyName;
        }

        /// <summary>
        /// get/sets companyName
        /// </summary>
        public string CompanyName
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
        /// get/sets contact person
        /// </summary>
        public string ContactPerson
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
        /// get/set fax
        /// </summary>
        public int Fax
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
        /// get/sets se_no
        /// </summary>
        public int Se_no
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
