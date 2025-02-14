namespace Day5_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books_imp = Books.Books_details();
            Console.WriteLine("1)Choose Book Using BookCode \n2)Choose Book Using Price Range");
            int n=int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("Entre the BooksCode");
                string code = Console.ReadLine();
                code=code.ToUpper();
                

                var result = from book in books_imp
                             where book.book_code == code
                             select book;
                if (result == null || result.Count() == 0)
                {
                    Console.WriteLine("Wrong BookCode");
                }
                else
                {
                    foreach (var book in result)
                    {
                        Console.WriteLine($"Book_Code:{book.book_code}\tBook_Name:{book.book_name}\tPublisher Name:{book.Publisher_name}\tAuthor Name:{book.Author_name}\tPrice:{book.Price}");
                    }
                }
            }

            else
            {
                Console.WriteLine("Entre the Price Range 1:");
                double num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre the Price Range 2:");
                double num2=int.Parse(Console.ReadLine());

                var result=from book in books_imp
                           where book.Price>num1 && book.Price < num2
                           select book;
                if (result == null || result.Count() == 0)
                {
                    Console.WriteLine("No Data Found");
                }
                else
                {
                    foreach (var book in result)
                    {
                        Console.WriteLine($"Book_Code:{book.book_code}\tBook_Name:{book.book_name}\tPublisher Name:{book.Publisher_name}\tAuthor Name:{book.Author_name}\tPrice:{book.Price}");

                    }
                }
                      

            }
        }
    }


}
