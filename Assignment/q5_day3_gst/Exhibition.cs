using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace q5
{
    internal class Exhibition:Event
    {
        private static int gst = 5;
        private int noOfStalls;

        public Exhibition() { }

        public Exhibition(string name, string type, double costPerDay, int noOfDays, int noOfStalls)
            : base(name, type, costPerDay, noOfDays)
        {
            this.noOfStalls = noOfStalls;
            
        }

        public double totalCost()
        {
            return costPerDay * noOfDays * (1 + gst / 100.0);
        }

        public override string ToString()
        {
            return $"Name:{name}\nType:{type}\nNumber of stalls:{noOfStalls}\nTotal amount: {totalCost():0.00}";
        }

        }
    }
