using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class SavingAccount:Account
    {
        private double interestRate {  get; set; }

        
        
        public SavingAccount() : base()
        {
        }

        
        public SavingAccount(string holderName, long accountNumber, string IFSCCode, long contactNumber, double interestRate)
            : base(holderName, accountNumber, IFSCCode, contactNumber)
        {
            this.interestRate = interestRate;
        }

       
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Interest Rate: {interestRate}");

        }
    }
}
