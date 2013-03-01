using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealerLibraries
{
    public class Private : Customer
    {
        private string name;
        private int age;
        private string sex;

        public Private(string address, int phone, string name, int age, string sex) :base (address, phone)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        /// <summary>
        /// get/sets age
        /// </summary>
        /// <remarks>get/set</remarks>
        public int Age
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

        //Shitty tostring
        public override string ToString()
        {
            return (this.Address+this.Phone+this.Name+this.Age+this.Sex);
        }

    }
}
