using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        protected Person(string name, string surname, int age)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
