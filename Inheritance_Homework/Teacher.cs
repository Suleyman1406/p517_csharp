
public class Teacher : Person
{
    public Teacher(string name, string surname, int age) : base(name, surname, age)
    {
    }

    public override void PrintPersonInfo()
    {
        Console.WriteLine($"name: {Name}, surname: {Surname}, age: {Age}, job: Teacher");
    }
}


