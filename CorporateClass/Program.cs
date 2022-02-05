// See https://aka.ms/new-console-template for more information
using CorporateClass;

Console.WriteLine("Hello, World!");

//In the Main method, create a company, and three employees, and then assign the employees to the company.

Company company = new Company("MB Inc.");
Employee emp1 = new Employee("Mary Beth Hunter", "CEO");
Employee emp2 = new Employee("Lauren Hignite", "CTO");
Employee emp3 = new Employee("Anna Hunter", "Attorney");

company.AddEmployee(emp1);
company.AddEmployee(emp2);
company.AddEmployee(emp3);

company.GetEmployees();