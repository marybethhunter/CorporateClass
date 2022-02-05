using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    internal class Employee
    {
        //Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.
        public Employee(string name, string title)
        {
            Name = name;
            JobTitle = title;
            StartDate = DateTime.Now;
        }

        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
    }
}
