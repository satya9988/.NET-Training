namespace q6_day3_constchain
{
    internal class Student : Person
    {
        int totalMarks;
        public Student(string name, string city, int totalMarks) : base(name, city)
        {
            this.totalMarks = totalMarks;
        }
        public bool IsOutStanding()
        {
            if (totalMarks > 90)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nTotal Marks Obtained:{totalMarks}";
        }
    }
}
