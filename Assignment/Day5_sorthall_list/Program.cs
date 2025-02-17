using System;

namespace Day5_sorthall_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No Of Halls");
            int n = int.Parse(Console.ReadLine());
            List<Hall> list = new List<Hall>();

            Console.WriteLine("Enter the Detais of Halls");
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s1 = s.Split(",");
                string name = s1[0];
                double costPerDay = s[1];
                string owner = s1[2];

                list.Add(new Hall(name, costPerDay, owner));

            }
            list.Sort((str1, str2) => str1._owner.CompareTo(str2._owner));

            Console.WriteLine("\n{0,-15}{1,-10}{2,-10}", "Name", "Cost", "Owner");

            
            foreach (Hall hall in list)
            {
                Console.WriteLine("{0,-15}{1,-10}{2,-10}", hall._name, hall._costPerDay, hall._owner);


            }
        }


    }
}
