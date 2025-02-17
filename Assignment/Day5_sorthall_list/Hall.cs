using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_sorthall_list
{
    internal class Hall:IComparable<Hall>
    {
        public string _name {  get; set; }
        public double _costPerDay { get; set; }
        public string _owner {  get; set; }

        public Hall(string name, double costPerDay, string owner)
        {
            this._name = name;
            this._costPerDay = costPerDay;
            this._owner = owner;

        }
        public int CompareTo(Hall? h1)
        {
            return _owner.CompareTo(h1._owner);
        }
    }

    
}
