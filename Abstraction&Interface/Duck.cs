using System;

public class Duck : Animal, ISwimmable
{
    public Duck(string name) : base(name)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Vak vak");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming");
    }

    //public void Test()
    //{
    //    Console.WriteLine("bu bir testdir");
    //}
}


