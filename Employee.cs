/*Constructor Chaining in Inheritance
Time: 15 mins
Create a class `Employee` with properties `Name` and `Salary`. 
Derive a class `Manager` that has an additional property `Bonus`.
Use constructor chaining to initialize the properties from the base class.*/

using System;

namespace inheritanceone
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            // Correcting the assignments
            Name = name;
            Salary = salary;
            Console.WriteLine("Employee constructor called");
        }
    }

    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager(string name, int salary, double bonus) : base(name, salary)
        {
            // Correcting the assignment
            Bonus = bonus;
            Console.WriteLine("Manager constructor called");
        }
    }
}