using ConsoleApp12;

public class Worker : Employee
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public List<Operation> Operations { get; set; }

    public Worker(string name, string surname, int age, decimal salary, DateTime startTime, DateTime endTime)
        : base(name, surname, age, salary)
    {
        StartTime = startTime;
        EndTime = endTime;
        Operations = new List<Operation>();
    }

    public void AddOperation(Operation operation)
    {
        Operations.Add(operation);
        Console.WriteLine($"{Name} {Surname} added operation: {operation.ProcessName}");
    }
}