namespace exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("no of customers");
            int n = int.Parse(Console.ReadLine());
            Customer[] c = new Customer[n];
            for (int i = 0; i < n; i++)
            {

                Console.Write("Rating from 1 to 5: ");
                double Feedback = double.Parse(Console.ReadLine());
                Console.Write("Mobile: ");
                string mobile = Console.ReadLine();
                Console.WriteLine("name: ");
                string name = Console.ReadLine();

                c[i] = new Customer(Feedback, mobile, name);
            }

            for (int i = 0; i < n; i++)
            {
                double feed = c[i].Feedback;
                Console.WriteLine($"Customer {i} :  {feed} out of 5 ");
            }

        }
    }

    class Customer
    {
        public double Feedback { get; set; }
        public string Moblie { get; set; }
        public string Name { get; set; }

        public Customer(double Feedback, string Moblie, string Name)
        {
            this.Feedback = Feedback;
            this.Moblie = Moblie;
            this.Name = Name;
        }


    }
}