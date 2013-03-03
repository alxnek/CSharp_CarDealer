using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Business : Customer
    {
        
        private int se_no;      
        private int fax;        
        private string contactPerson;        
        private string companyName;

        private List<Leasing> leaseList = new List<Leasing>();

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
        /// Adds a lease to the business customer
        /// </summary>
        /// <remarks>Leasing's list</remarks>
        public void AddLease(Leasing lease)
        {
            this.leaseList.Add(lease);
        }

        /// <summary>
        /// Delete a lease
        /// </summary>
        /// <remarks>leasing's list</remarks>
        public void DeleteContract(Leasing lease)
        {
            this.leaseList.Remove(lease);
        }
        /// <summary>
        /// get/sets companyName
        /// </summary>
        /// <remarks>get/sets</remarks>
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
        /// <remarks>get/sets</remarks>
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
        /// get/sets fax
        /// </summary>
        /// <remarks>get/sets</remarks>
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
        /// <remarks>get/sets</remarks>
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


        /// <summary>
        /// Override ToString, show fields
        /// </summary>
        /// <remarks>string with the fields</remarks>
        public override string ToString()
        {
            string result = string.Join("\n\n", this.leaseList);

            return ("\n***Business customer***\nAddress: " + this.Address + "\nPhone: " + this.Phone + "\nContact Person: " + this.ContactPerson + "\nFax: " + this.Fax + "\nCompany Name: " + this.CompanyName + "\nSe_no: " + this.Se_no + "\n\nContracts of this customer---------->\n " + result);
        } 
    }
}
