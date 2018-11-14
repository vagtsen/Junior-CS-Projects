using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationComposition
{
    class Manager : Employee
    {

        public Manager(string name, string street, string city, string perfecture, string postalcode) : base(name, street, city, perfecture, postalcode)
        {

        }
        public static String GivePraise()
        {
            return "Manager giving praise";
        }

        public override string DoWork() // 
        {
            return "Manager doing work!";
        }

    }
}
