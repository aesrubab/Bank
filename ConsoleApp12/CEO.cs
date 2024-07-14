using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Ceo : Employee
    {
        public Ceo(string name, string surname, int age, decimal salary)
            : base(name, surname, age, salary) { }

        public void Organize()
        {
            Console.WriteLine($"{Name} {Surname} is organizing");
        }

        public void MakeMeeting()
        {
            Console.WriteLine($"{Name} {Surname} is making a meeting");
        }

        public void DecreasePercentage(decimal percent)
        {
            Salary -= Salary * percent / 100;
            Console.WriteLine($"{Name} {Surname} salary decreased by {percent}%.");
        }
    }
}


