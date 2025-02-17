using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PlacedStudent> placedStudents = new List<PlacedStudent>();

            Console.WriteLine("Enter number of companies:");
            int numberOfCompanies = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCompanies; i++)
            {
                Console.WriteLine("Enter company name:");
                string companyName = Console.ReadLine();

                Console.WriteLine("Enter student name:");
                string studentName = Console.ReadLine();

                placedStudents.Add(new PlacedStudent(companyName, studentName));
            }

            var Students_list = from ps in placedStudents
                                  group ps by ps.CompanyName into company
                                  orderby company.Key
                                  select new
                                  {
                                      CompanyName = company.Key,
                                      Students = from s in company
                                                 orderby s.StudentName
                                                 select s
                                  };

            foreach (var i in Students_list)
            {
                Console.WriteLine($"Company Name: {i.CompanyName}");
                foreach (var student in i.Students)
                {
                    Console.WriteLine(student.StudentName);
                }
            }
        }
    }
}
