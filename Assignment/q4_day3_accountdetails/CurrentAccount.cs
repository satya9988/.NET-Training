using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class CurrentAccount:Account
    {
        private string organizationName {  get; set; }
        private long TIN {  get; set; }

       

        
        public CurrentAccount() : base()
        {
        }

        
        public CurrentAccount(string holderName, long accountNumber, string IFSCCode, long contactNumber, string organizationName, long TIN)
            : base(holderName, accountNumber, IFSCCode, contactNumber)
        {
            this.organizationName = organizationName;
            this.TIN = TIN;
        }

        
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Organization Name: {organizationName}");
            Console.WriteLine($"TIN: {TIN}");
        }
    }
}
