

public class Student : IPerson
{

    public Student(string name, double grade)
    {
        this.Name = name;
        this.Grade = grade;
    }

    public string Name { get; set; }
    public double Grade { get; set; }

    public void Walk()
    {
        Console.WriteLine("Student is walking");
    }
}


