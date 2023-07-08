using System;

public class Animal
{
    private string name;
    public string Name {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    void printAnimalName()
    {
        Console.WriteLine($"Animal name: {name}");
    }

    public Animal()
    {
        name = "Miki";
    }

    //public string getName()
    //{
    //    return name;
    //}

    //public void setName(string _name)
    //{
    //    name = _name;
    //}
}


