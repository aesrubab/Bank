using ConsoleApp12;

class Program
{
    static void Main(string[] args)
    {
        Ceo ceo = new Ceo("Rubab", "Huseynova", 20, 100000m);

        Bank bank = new Bank("Rubab's Bank", 1000000m, ceo);

        Manager manager1 = new Manager("Aygun", "Bayramova", 20, 50000m);
        Manager manager2 = new Manager("Sabina", "Shakiyeva", 20, 50000m);

        bank.Managers.AddRange(new List<Manager> { manager1, manager2 });

        Worker worker1 = new Worker("Nizami", "Amirov", 20, 5000m, DateTime.Now, DateTime.Now.AddHours(8));
        Worker worker2 = new Worker("Munevver", "Musayeva", 15, 4000m, DateTime.Now, DateTime.Now.AddHours(8));

        bank.Workers.AddRange(new List<Worker> { worker1, worker2 });

        Client client1 = new Client("Elsen", "Murselov", 20, "Baki", "baki", 10000m);
        Client client2 = new Client("Revan", "Agazade", 20, "Baki", "Baki", 5000m);

        bank.Clients.AddRange(new List<Client> { client1, client2 });

        Credit credit1 = new Credit(client1, 60000m, 15, 12);
        Credit credit2 = new Credit(client2, 19000m, 16, 24);

        client1.Credits.Add(credit1);
        client2.Credits.Add(credit2);

        bank.ShowClientCredits("Elsen Murselov");
        bank.ShowClientCredits("Revan Agazade");

        decimal profit = bank.CalculateProfit();
        Console.WriteLine($"Bank Profit: {profit}");

        ceo.MakeMeeting();

        manager1.Organize();
        decimal manager1Salary = manager1.CalculateSalary();
        Console.WriteLine($"Manager1 Salary: {manager1Salary}");

        Operation operation = new Operation("Kocurme", DateTime.Now);
        worker1.AddOperation(operation);

        bank.PayCredit(client1, 5000m);

        bank.ShowAllCredits();
    }
}
