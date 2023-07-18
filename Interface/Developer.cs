
public class Developer : Worker
{
    public int Experience { get; set; }

    public Developer(string name, string job, int experience) : base(name, job)
    {
        this.Experience = experience;
    }

    public override void Walk()
    {
        Console.WriteLine("Developer is walking");
    }
}



