using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("no of employee");
            int n = int.Parse(Console.ReadLine());
            Details[] dl = new Details[n];
            for (int i = 0; i < dl.Length; i++)
            {
                Console.Write("Empid: ");
                int empid = int.Parse(Console.ReadLine());
                Console.Write("Empname: ");
                string empname = Console.ReadLine();
                Console.Write("Empsalary: ");
                long salary = long.Parse(Console.ReadLine());
                Console.Write("depid: ");
                int depid = int.Parse(Console.ReadLine());
                dl[i] = new Details(empid, empname, salary, depid);
                Console.Write("\n");
            }

            for (int i = 0; i < dl.Length; i++)
            {
                Console.WriteLine(dl[i].empid + "\t" + dl[i].empname + "\t" + dl[i].salary + "\t" + dl[i].depid);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("");
            }
            long total = Details.get_total_salray();
            Console.WriteLine("Total Salary: " + total);


        }
    }

    class Details
    {
        public int empid { get; }
        public string empname { get; }
        public long salary { get; }
        public int depid { get; }
        public static long total = 0;

        public Details(int empid, string empname, long salary, int depid)
        {
            this.empid = empid;
            this.empname = empname;
            this.salary = salary;
            this.depid = depid;
            total += salary;
        }
        public static long get_total_salray()
        {
            return total;
        }


    }
}