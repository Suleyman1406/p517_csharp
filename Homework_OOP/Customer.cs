
public class Customer : IPerson
{
    public static Customer[] customers;

    static Customer()
    {
        customers = new Customer[0];
    }

    public Customer(string id, string name,string surname, int age)
    {
        this.ID = id;
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        this.Money = 0;
        Array.Resize(ref customers, customers.Length + 1);
        customers[customers.Length - 1] = this;
    }

    public double Money { get; set; }
    public string ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public void PrintPersonInfo()
    {
        Console.WriteLine($"FIN: {ID}, {Name} {Surname}, age: {Age}");
    }
}


