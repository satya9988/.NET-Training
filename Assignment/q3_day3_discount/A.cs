using System;
namespace q3
{
    public class A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1) Privilege Customer");
            Console.WriteLine("2) SeniorCitizen Customer");
            Console.Write("Enter Customer Type: ");
            int customerType = int.Parse(Console.ReadLine());

            if (customerType != 1 && customerType != 2)
            {
                Console.WriteLine("\nInvalid Customer Type");
                return;
            }

            Console.Write("Enter The Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter The Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter The Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter The Mobile Number: ");
            string mobileNumber = Console.ReadLine();

            Console.Write("Enter The Purchased Amount: ");
            int amount = int.Parse(Console.ReadLine());

            Customer customer;
            double billAmount;

            if (customerType == 1)
            {
                customer = new PrivilegeCustomer(name, address, mobileNumber, age);
                billAmount = ((PrivilegeCustomer)customer).GenerateBillAmount(amount);
            }
            else
            {
                customer = new SeniorCitizenCustomer(name, address, mobileNumber, age);
                billAmount = ((SeniorCitizenCustomer)customer).GenerateBillAmount(amount);
            }

            Console.WriteLine("\nBill Details");
            customer.DisplayCustomer();
            Console.WriteLine($"Your bill amount is Rs {amount:F1}.");
            if (customerType == 1)
            {
                Console.WriteLine("Your bill amount is discount under privilege customer");
            }
            else
            {
                Console.WriteLine("Your bill amount is discount under senior citizen customer");
            }
            Console.WriteLine($"You have to pay Rs {billAmount:F2}");
        }
    }
}
