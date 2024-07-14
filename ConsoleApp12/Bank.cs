using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Bank
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Profit { get; set; }
        public Ceo Ceo { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Client> Clients { get; set; }

        public Bank(string name, decimal budget, Ceo ceo)
        {
            Name = name;
            Budget = budget;
            Ceo = ceo;
            Workers = new List<Worker>();
            Managers = new List<Manager>();
            Clients = new List<Client>();
        }

        public decimal CalculateProfit()
        {
            Profit = Clients.Sum(client => client.Credits.Sum(credit => credit.CalculatePercent()));
            return Profit;
        }

        public void ShowClientCredits(string fullName)
        {
            var client = Clients.FirstOrDefault(c => $"{c.Name} {c.Surname}" == fullName);
            if (client != null)
            {
                Console.WriteLine($"Credits for {fullName}:");
                foreach (var credit in client.Credits)
                {
                    Console.WriteLine($" Amount: {credit.Amount}, Percent: {credit.Percent}, Payment: {credit.Payment()}");
                }
            }
            else
            {
                Console.WriteLine($"Client {fullName} not found");
            }
        }

        public void PayCredit(Client client, decimal money)
        {
            var credit = client.Credits.FirstOrDefault();
            if (credit != null)
            {
                credit.Amount -= money;
                Console.WriteLine($"{client.Name} {client.Surname} paid {money} for credit");
            }
        }

        public void ShowAllCredits()
        {
            Console.WriteLine("All Credits in the Bank:");
            foreach (var client in Clients)
            {
                foreach (var credit in client.Credits)
                {
                    Console.WriteLine($"Client: {client.Name} {client.Surname}, Amount: {credit.Amount}, Percent: {credit.Percent}, Payment: {credit.Payment()}");
                }
            }
        }
    }
}
