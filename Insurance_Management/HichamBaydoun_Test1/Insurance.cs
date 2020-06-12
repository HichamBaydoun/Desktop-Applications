using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HichamBaydoun_Test1
{
    class Insurance
    {
        //properties
        private string type;
        private string customer;
        private string phone;
        private int policyAmount;
        private int years;

        //constructor
        public Insurance(string type, string customer, string phone, int policyAmount, int years)
        {
            this.type = type;
            this.customer = customer;
            this.phone = phone;
            this.policyAmount = policyAmount;
            this.years = years;
        }

        //getters and setters
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int PolicyAmount
        {
            get { return policyAmount; }
            set { policyAmount = value; }
        }

        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        //ToString()
        public override string ToString()
        {
            return "Insurance Deatails: " + type + ", " + customer + ", " + phone + ", " + (policyAmount * years);
        }

    }
}
