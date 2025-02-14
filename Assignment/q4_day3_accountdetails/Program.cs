namespace q4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Holder Name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            long accountNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter IFSC Code: ");
            string IFSCCode = Console.ReadLine();

            Console.Write("Enter Contact Number: ");
            long contactNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Account Type (saving/current): ");
            string accountType = Console.ReadLine();

            

            if (accountType == "saving")
            {
                Console.Write("Enter Interest Rate: ");
                double interestRate = double.Parse(Console.ReadLine());
                SavingAccount account1 = new SavingAccount(holderName, accountNumber, IFSCCode, contactNumber, interestRate);
                account1.Display();
            }
            else if (accountType == "current")
            {
                Console.Write("Enter Organization Name: ");
                string organizationName = Console.ReadLine();
                Console.Write("Enter TIN number: ");
                long TIN = long.Parse(Console.ReadLine());
               CurrentAccount account2 = new CurrentAccount(holderName, accountNumber, IFSCCode, contactNumber, organizationName, TIN);
                account2.Display();
            }
            else
            {
                Console.WriteLine("Enter valid Account Type");
                return;
            }

           
        }

        }
    }
