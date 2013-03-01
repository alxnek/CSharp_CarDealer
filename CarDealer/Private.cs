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
                throw new System.NotImplementedException();
            }
            set
            {
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
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// get/sets sex
        /// </summary>
        public string Sex
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public override string ToString()
        {
            return (this.Address+this.Phone);
        }

    }
}
