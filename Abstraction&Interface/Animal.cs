using System;

public abstract class Animal
{
    private string name;

    public Animal(string name)
	{
		this.Name = name;
	}

    public abstract void MakeNoise();

    public void printInfo()
    {
        Console.WriteLine();
    }

    public string Name { get => name; set => name = value; }
}

