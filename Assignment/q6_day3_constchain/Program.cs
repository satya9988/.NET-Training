using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace q6_day3_constchain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.student\n2.faculty");
            int ch = int.Parse(Console.ReadLine());
            Person p;
            if (ch == 1)
            {
                Console.WriteLine("No of Student");
                int count = int.Parse(Console.ReadLine());
                Student[] students = new Student[count];
                string name;
                string city;
                int marks;
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine("Enter the name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the city");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter the marks");
                    marks = int.Parse(Console.ReadLine());
                    students[i] = new Student(name, city, marks);
                }
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].IsOutStanding())
                    {
                        Console.WriteLine(students[i]);
                    }
                }
            }
            else if (ch == 2)
            {
                Console.WriteLine("no of Faculty");
                int count = int.Parse(Console.ReadLine());
                Faculty[] faculty = new Faculty[count];
                string name;
                string city;
                int books;
                for (int i = 0; i < faculty.Length; i++)
                {
                    Console.WriteLine("Enter the name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the city");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter the no of books");
                    books = int.Parse(Console.ReadLine());
                    faculty[i] = new Faculty(name, city, books);
                }
                for (int i = 0; i < faculty.Length; i++)
                {
                    if (faculty[i].IsOutStanding())
                    {
                        Console.WriteLine(faculty[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}
