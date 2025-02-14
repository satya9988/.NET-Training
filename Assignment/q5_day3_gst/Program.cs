namespace q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter event name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the cost per day");
            double costPerDay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of days");
            int noOfDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of event\n1.Exhibition\n2.Stage Event");
            int eventType = int.Parse(Console.ReadLine());

            Event eventObj;

            if (eventType == 1)
            {
                Console.WriteLine("Enter the number of stalls");
                int noOfStalls = Convert.ToInt32(Console.ReadLine());
                 eventObj = new Exhibition(name, "Exhibition", costPerDay, noOfDays, noOfStalls);
            }
            else if (eventType == 2)
            {
                Console.WriteLine("Enter the number of seats");
                int noOfSeats = Convert.ToInt32(Console.ReadLine());
                eventObj = new StageEvent(name, "Stage Event", costPerDay, noOfDays, noOfSeats);
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Event Details");
            Console.WriteLine(eventObj.ToString());
        

    }
    }
}
