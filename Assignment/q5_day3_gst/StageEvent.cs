using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace q5
{
    internal class StageEvent:Event
    {
        private static int gst = 15;
        private int noOfSeats;
       

        public StageEvent() { }

        public StageEvent(string name, string type, double costPerDay, int noOfDays, int noOfSeats)
            : base(name, type, costPerDay, noOfDays)
        {
            this.noOfSeats = noOfSeats;
        }

        public double totalCost()
        {
            return costPerDay * noOfDays * (1 + gst / 100.0);
        }

        public override string ToString()
        {
            return $"Name:{name}\nType:{type}\nNumber of seats:{noOfSeats}\nTotal amount: {totalCost():0.00}";

        }
    }
}
