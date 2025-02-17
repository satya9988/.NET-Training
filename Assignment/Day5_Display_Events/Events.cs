using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Display_Events
{
    internal class Events
    {
        private string _eventName {  get; set; }

        private string _organiserName { get; set; }

        private double _eventCost { get; set; }

        public Events(string eventName,string organisername, double eventCost)
        {
            this._eventName = eventName;
            this._organiserName = organisername;
            this._eventCost = eventCost;
        }

        public  override string ToString()
        {
            return $"{_eventName}|{_organiserName}|{_eventCost}";
        }

        public static void Display(List<Events> events)
        {
            Console.WriteLine("\nList Of Events: ");
            events.ForEach(e => Console.WriteLine(e.ToString()));
        }
         

    }
}
