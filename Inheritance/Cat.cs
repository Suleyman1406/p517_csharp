using System;

public class Cat : Animal
{

    public Cat(string name, int age) : base(name, age)
    {
      
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Miaw");
    }
}


