
public class Worker : IPerson
{
    public Worker(string name, string job)
    {
        this.Name = name;
        this.Job = job;

    }

    public string Name { get; set; }
    public string Job { get; set; }

    public virtual void Walk()
    {
        Console.WriteLine("Worker is Walking");
    }
}


