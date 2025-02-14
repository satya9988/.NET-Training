using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    internal class Event
    {
        protected string name;
        protected string type;
        protected double costPerDay;
        protected int noOfDays;

        public Event() { }

        public Event(string name, string type, double costPerDay, int noOfDays)
        {
            this.name = name;
            this.type = type;
            this.costPerDay = costPerDay;
            this.noOfDays = noOfDays;

        }
    }
}

