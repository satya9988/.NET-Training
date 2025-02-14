using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class SeniorCitizenCustomer:Customer
    {
        public SeniorCitizenCustomer(string name, string address, string mobileNumber, int age)
        : base(name, address, mobileNumber, age)
        {
        }

        public double GenerateBillAmount(int amount)
        {
            double discount = amount * 0.12;
            return amount - discount;

        }
    }
}
