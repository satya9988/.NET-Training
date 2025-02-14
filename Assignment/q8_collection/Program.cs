
namespace q8_collection
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id=101, Name="TV", Description="watch movies", Price=20000 });
            products.Add(new Product { Id = 103, Name = "TV ", Description = "aa", Price = 1500 });
            products.Add(new Product { Id = 102, Name = "Phone", Description = "call", Price = 25000 });

            Console.WriteLine("Enter by which variable you want to sort {1:id, 2:name,3:price}");
            int n=int.Parse(Console.ReadLine());

            if (n == 1)
            {
                products.Sort();
            }
            else if (n == 2) 
            {
                products.Sort(new sortbyprice()); 
            }
            else
            {
                products.Sort(new sortbyname());
            }


            IEnumerator<Product> p = products.GetEnumerator();
            while (p.MoveNext())
            {
                Console.WriteLine(p.Current.ToString());
            }
        }
    }

    class Product:IComparable<Product> 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        

        public int CompareTo(Product? other)
        {
            if (this.Id > other.Id)
            {
                return 1;
            }
            else if (this.Id < other.Id)
            {
                return -1; 
            }
            return 0;
        }

        public override string ToString()
        {
            return $"Product_Id:{Id}\tProduct_Name:{Name}\tDiscrption:{Description}\tPrice:{Price}";
        }
    }

    public class sortbyprice : IComparer<Product>
    {
        int IComparer<Product>.Compare(Product? x, Product? y)
        {
            if (x.Price > y.Price)
            {
                return 1;
            }
            else if ((x.Price < y.Price))
            {
                return -1;
            }
            else
            {
                if(x.Id > y.Id)
                {
                    return 1;
                }
                else if(x.Id < y.Id)
                {
                    return -1;
                }
                return 0;
            }
        }
    }

    public class sortbyname : IComparer<Product>
    {
        int IComparer<Product>.Compare(Product? x, Product? y)
        {
            int k = x.Name.CompareTo(y.Name);
            if ( k== 1)
            {
                return -1;
            }
            else if (k == -1)
            {
                return 1;
            }
            else
            {
                int s=x.Description.CompareTo(y.Description);
                if( s== 1)
                {
                    return -1;
                }
                else if(s== -1)
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}
