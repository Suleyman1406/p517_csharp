public interface IPerson
{

    string ID { get; set; }
    string Name { get; set; }
    string Surname { get; set; }
    int Age { get; set; }

    void PrintPersonInfo();
    
}


