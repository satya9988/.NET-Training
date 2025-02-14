using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Account
    {
        private string holderName { get; set; }
        private long accountNumber { get; set; }
        private string IFSCCode { get; set; }
        private long contactNumber { get; set; }

        public Account()
        {

        }
        public Account(string holderName, long accountNumber, string IFSCCode, long contactNumber)
        {
            this.holderName = holderName;
            this.accountNumber = accountNumber;
            this.IFSCCode = IFSCCode;
            this.contactNumber = contactNumber;
        }

        public void Display()
        {
            Console.WriteLine("\nYour Contact Details");
            Console.WriteLine($"HolderName : {holderName}");
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"IFSCCode : {IFSCCode}");
            Console.WriteLine($"ContactNumber : {contactNumber}");

        }
    }
}
