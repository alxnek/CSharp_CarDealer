using System;
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
               return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }

        /// <summary>
        /// get/sets contact person
        /// </summary>
        public string ContactPerson
        {
            get
            {
                return this.contactPerson;
            }
            set
            {
                this.contactPerson = value;
            }
        }

        /// <summary>
        /// get/set fax
        /// </summary>
        public int Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                this.fax = value;
            }
        }

        /// <summary>
        /// get/sets se_no
        /// </summary>
        public int Se_no
        {
            get
            {
                return this.se_no;
            }
            set
            {
                this.se_no = value;
            }
        }
            
        //Shityy tostring
        public override string ToString()
        {
            return (this.Address+this.Phone+this.ContactPerson+this.Fax+this.CompanyName+this.Se_no);
        } 
    }
}
