using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Operation
    {
        public Guid Id { get; set; }
        public string ProcessName { get; set; }
        public DateTime DateTime { get; set; }

        public Operation(string processName, DateTime dateTime)
        {
            Id = Guid.NewGuid();
            ProcessName = processName;
            DateTime = dateTime;
        }
    }
}