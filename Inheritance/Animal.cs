using System;

public class Animal
{
    protected string name;
    public int age;

    public Animal(string name, int age)
	{
        this.name = name;
        this.age = age;
    }

    public void Run()
    {
        Console.WriteLine($"{name} is running");
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine($"{name} is making noise.");
    }
}


