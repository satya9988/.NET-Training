namespace q6_day3_constchain
{
    internal class Faculty : Person
    {
        int no_of_books_published;
        public Faculty(string name, string city, int no_of_books_published) : base(name, city)
        {
            this.no_of_books_published = no_of_books_published;
        }
        public bool IsOutStanding()
        {
            if (no_of_books_published > 5)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNo of Books Published:{no_of_books_published}";
        }
    }
}

