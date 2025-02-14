namespace q6_day3_constchain
{
    internal class Person
    {
        string name;
        string city;
        public Person(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
        public void display()
        {
            Console.WriteLine("Name:" + name + "\ncity:" + city);
        }
        public override string ToString()
        {
            return $"Name:{name}\nCity:{city}";
        }
    }
}
