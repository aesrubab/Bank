using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Client : Person
    {
        public string LiveAddress { get; set; }
        public string WorkAddress { get; set; }
        public List<Credit> Credits { get; set; }

        public Client(string name, string surname, int age, string liveAddress, string workAddress, decimal salary)
            : base(name, surname, age)
        {
            LiveAddress = liveAddress;
            WorkAddress = workAddress;
            Credits = new List<Credit>();
        }
    }
}
