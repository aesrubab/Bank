using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Manager : Employee
    {
        public Manager(string name, string surname, int age, decimal salary)
            : base(name, surname, age, salary) { }

        public void Organize()
        {
            Console.WriteLine($"{Name} {Surname} is organizing");
        }

        public decimal CalculateSalary()
        {
            Console.WriteLine($"{Name} {Surname} salary is {Salary}");
            return Salary;
        }
    }
}
