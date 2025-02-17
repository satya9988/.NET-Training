using System;
using System.IO;

namespace Day5_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            readfile();
        }

        public static void readfile()
        {
            FileStream f1 = null;
            FileStream f2 = null;
            try
            {
                f1 = new FileStream("C:\\Users\\satyanarayana.k\\OneDrive - Tavant Technologies\\Desktop\\C#\\Assignment\\products.txt", FileMode.Open, FileAccess.Read);
                f2 = new FileStream("C:\\Users\\satyanarayana.k\\OneDrive - Tavant Technologies\\Desktop\\C#\\Assignment\\products_updated.txt", FileMode.Create, FileAccess.Write);
                StreamReader sr = new StreamReader(f1);
                StreamWriter sr2 = new StreamWriter(f2);
                string str = sr.ReadLine();

                while (!string.IsNullOrEmpty(str))
                {
                    Console.WriteLine(str);
                    string[] arr = str.Split(",");
                    double n = double.Parse(arr[2]);

                    if (n < 1000)
                    {
                        n += n * 0.10;
                    }
                    else if (n >= 1000 && n < 5000)
                    {
                        n += n * 0.05;
                    }

                    arr[2] = n.ToString();

                    sr2.WriteLine(arr[0] + " " + arr[1] + " " + arr[2]);
                    str = sr.ReadLine();

                    
                }

                sr.Close();
                sr2.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (f1 != null)
                    f1.Close();
            }
        }
    }
}
