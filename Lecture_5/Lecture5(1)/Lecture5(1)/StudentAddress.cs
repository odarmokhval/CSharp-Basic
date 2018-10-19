using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    public class StudentAddress
    {
        private string country;
        private string town;
        private string address;

        public StudentAddress(string country, string city, string adress)
        {
            this.country = country;
            this.town = city;
            this.address = adress;
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string Town
        {
            get
            {
                return town;
            }

            set
            {
                if (value != null)
                {
                    town = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public override string ToString()
        {
            return "StudentAddress: " + address + " " + town + " " + country;
        }

    }
}
