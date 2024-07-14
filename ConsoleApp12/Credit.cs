using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Credit
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public decimal Amount { get; set; }
        public decimal Percent { get; set; }
        public int Month { get; set; }

        public Credit(Client client, decimal amount, decimal percent, int month)
        {
            Id = Guid.NewGuid();
            Client = client;
            Amount = amount;
            Percent = percent;
            Month = month;
        }

        public decimal CalculatePercent()
        {
            return Amount * Percent / 100;
        }

        public decimal Payment()
        {
            return Amount + CalculatePercent();
        }
    }
}
