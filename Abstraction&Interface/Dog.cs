using System;

public class Dog : Animal
{

    public Dog(string name) : base(name)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Hav hav");
    }
}


