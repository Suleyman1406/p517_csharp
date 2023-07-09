using System;

public class Rabbit : Animal
{
    public int longEarCount;


    public Rabbit(string name, int age, int longEarCount): base(name, age)
	{
        this.longEarCount = longEarCount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{name} {age} {longEarCount}");
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Xir xir");
    }
}


