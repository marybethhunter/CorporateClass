using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    internal class Company
    { 
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;
        }

    // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees

        private List <Employee> _employees = new List<Employee>();

        // Create a method that allows a caller to add an employee

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        // Create a method that allows a caller to remove an employee

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

        // Create a method that allows a caller to retrieve the list of employees

        public void GetEmployees()
        {
            foreach (Employee employee in _employees)
            {
                Console.WriteLine($"{employee.Name}, {employee.JobTitle}");
            }
        }
    }
}
