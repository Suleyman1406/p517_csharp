using System;

public class Dog : Animal
{
	public Dog(string name, int age) : base(name,age)
	{
	
	}

    public override void MakeNoise()
    {
        Console.WriteLine("Hav Hav");
    }
}


