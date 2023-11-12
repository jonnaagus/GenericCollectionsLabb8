using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsLabb8
{
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        // Constructor
        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Overridden ToString method to easily display information about an employee
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}";
        }
    }
}
