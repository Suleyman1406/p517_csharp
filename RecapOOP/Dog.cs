using System;


public class Dog
{
    private int age;
    private string name;

    public int Age { get => age; set => age = value; }
    public string Name { get => name; private set => name = value; }

    public Dog(string name, int age )
	{
		this.Name = name;
		this.Age = age;
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
}


