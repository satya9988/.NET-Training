using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Books
{
    internal class Books
    {
        public string book_code {  get; set; }
        public string book_name { get; set; }
        public string Publisher_name { get; set; }
        public string Author_name { get; set; }
        public double Price { get; set; }

        public static List<Books> Books_details()
        {
            return new List<Books>
            { new Books{book_code= "ASPNA", book_name = "ASP.net", Publisher_name = "Wrox", Author_name = "Bill Even", Price = 750.00 },
            new Books{book_code= "ASPNB", book_name = "Begining ASP.net", Publisher_name = "steeev", Author_name = "Van  rock", Price = 540.00 },
            new Books{book_code= "LNQA", book_name = "learning LNQA", Publisher_name = "rexeron", Author_name = "james rick", Price = 400.00 },
            new Books{book_code= "CSPN", book_name = "C# learinng", Publisher_name = "hussan", Author_name = "john snow", Price = 675.00 }
            };
        }
    }
}
