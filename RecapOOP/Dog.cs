using System;


public class Dog
{
    
    private string name;

    private int age;

	public int Age { get => Age; set => Age = value; }

    public string Name { get => name; private set => name = value; }

	public Dog(string name, int age)
	{
		this.Name = name;
		Age = age;
	}

	public Dog(string name)
	{
		this.Name = name;
		this.Age = 0;
	}

	public void printDogName()
	{
		Console.WriteLine($"My name is {Name}");
	}

	//public string getName()
	//{
	//	return name;
	//}

	//public void setName(string name)
	//{
	//	//name = _name;
	//	this.name = name;
	//}

	public void PrintHello()
	{
		Console.WriteLine("Hello");
	}

	

	public void PrintHello(string name = "Sirinov", int age = 12)
	{
        Console.WriteLine($"Hello {name}");
    }
}


