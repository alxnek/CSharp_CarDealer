using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    public class Private : Customer
    {
        private string name;
        private string age;
        private string sex;

        public Private(string address, int phone, string name, string age, string sex)
            : base(address, phone)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        /// <summary>
        /// get/sets age
        /// </summary>
        /// <remarks>get/set</remarks>
        public string Age
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


        public override string ToString()
        {
            return ("\n\n***Private customer***\nAddress: " + this.Address + "\nPhone: " + this.Phone + "\nName: " + this.Name + "\nAge: " + this.Age + "\nSex: " + this.Sex + "\n");
        }

    }
}
