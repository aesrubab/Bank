using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public abstract class Employee : Person
    {
        public decimal Salary { get; set; }

        protected Employee(string name, string surname, int age, decimal salary)
            : base(name, surname, age)
        {
            Salary = salary;
        }
    }
}
