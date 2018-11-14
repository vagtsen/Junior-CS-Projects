using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationComposition
{
    class Employee
    {
        public string Name { get; set; }
        public AddresInfo  Address{ get; set; }
        public InsuranceInfo Insurance { get; set; }

        public Employee(string name,string street, string city, string perfecture,string postalcode)
        {
            Name = name;
            Address = new AddresInfo()
            {
                Srteet = street,
                City = city,
                Perfecture = perfecture,
                PostalCode = postalcode
            };
        }

        public virtual string DoWork()
        {
            return "Employee doing work!";
        }

        public override string ToString()
        {
            string employee = Name + " " +
                 Address.Srteet + " " +
                 Address.City + " " +
                 Address.Perfecture + " " +
                 Address.PostalCode;

            if(Insurance!= null)
            {
                employee += " " + 
                    Insurance.PolicyId + " " +
                    Insurance.PolicyName;
            }
            return employee;
        }
    }
}
