using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    [Serializable]
    public class Private : Customer
    {
        private string name;
        private DateTime? age;
        private string sex;
        
        private List<Contract> contractList = new List<Contract>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>Create</remarks>
        public Private(string address, int phone, string name, DateTime? age, string sex)
            : base(address, phone)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        /// <summary>
        /// Adds a contract to the private customer
        /// </summary>
        /// <remarks>Contract's list</remarks>
        public void AddContract(Contract contract)
        {
            this.contractList.Add(contract);
        }

        /// <summary>
        /// Delete a contract
        /// </summary>
        /// <remarks>contract's list</remarks>
        public void DeleteContract(Contract contract)
        {
            this.contractList.Remove(contract);
        }


        /// <summary>
        /// get/sets age
        /// </summary>
        /// <remarks>get/set</remarks>
        public DateTime? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        /// <summary>
        /// get/sets name
        /// </summary>
        /// <remarks>get/set</remarks>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// get/sets sex
        /// </summary>
        public string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }


        /// <summary>
        /// Override ToString, show fields in string
        /// </summary>
        /// <remarks>show fields</remarks>
        public override string ToString()
        {
            string result = string.Join("\n", this.contractList);
            return ("***Private customer***\nAddress: " + this.Address + "\nPhone: " + this.Phone + "\nName: " + this.Name + "\nAge: " + calcAge() + "\nSex: " + this.Sex + "\n\nContracts of this customer---------->\n " + result);
        }

        /// <summary>
        /// get/set contracts
        /// </summary>
        /// <remarks>get/set</remarks>
        public List<Contract> ContractList
        {
            get
            {
                return this.contractList;
            }
            set
            {
                this.contractList = value;
            }
        }

         private int calcAge()
        {
            DateTime dtOne = DateTime.Today;

            DateTime dtTwo = this.Age ?? DateTime.Now;
            TimeSpan difference = dtOne - dtTwo;

             
            int output = Convert.ToInt32(difference.Days);
            return output/365;
        }

    }
}
