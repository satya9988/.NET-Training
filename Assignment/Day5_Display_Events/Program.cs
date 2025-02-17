namespace Day5_Display_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter No Of Events");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Entre the Event Details :");
            List<Events> e = new List<Events>();

            for (int i = 0; i < n; i++)
            {
                string s=Console.ReadLine();
                string[] s1 = s.Split(",");
                string name=s1[0];
                string orag=s1[1];
                double cost=double.Parse(s1[2]);
                 e.Add(new Events(name, orag, cost));
            }
            Events.Display(e);
            
        }
    }
}
