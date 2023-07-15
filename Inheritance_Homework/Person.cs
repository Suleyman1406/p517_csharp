
public class Person
{
    private string name;
    private string surname;
    private int age;

    public Person(string name, string surname, int age)
    {
        this.Age = age;
        this.Surname = surname;
        this.Name = name;
    }

    public int Age
    {
        get => age;
        set
        {
            if (value < 0)
            {
                throw new Exception("Age must be greater than 0");
            }
            age = value;
        }
    }
    public string Surname { get => surname; set => surname = value; }
    public string Name { get => name; set => name = value; }

    public virtual void PrintPersonInfo()
    {
        Console.WriteLine($"name: {Name}, surname: {Surname}, age: {Age}");
    }
}


