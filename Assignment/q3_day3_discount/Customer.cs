using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class Customer
    {
        protected string name;
        protected string address;
        protected string mobileNumber;
        protected int age;

        public Customer(string name, string address, string mobileNumber, int age)
        {
            this.name = name;
            this.address = address;
            this.mobileNumber = mobileNumber;
            this.age = age;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Mobile: {mobileNumber}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");

        }
    }
}
