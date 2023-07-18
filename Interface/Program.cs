Student student1 = new Student("Aqil", 77.4);
Worker worker1 = new Worker("Kamil", "system adminstrator");
Worker developer1 = new Developer("Isa", "Frontend Dev", 5);

//IPerson person = student1;
//person.Walk();

//PrintPersonName(student1);
//PrintPersonName(worker1);
//PrintPersonName(developer1);

//void PrintPersonName(IPerson person)
//{
//    Console.WriteLine(person.Name);
//}

//byte a = 123;
//int b = a;

//PrintPersonSpecialData(student1);
//PrintPersonSpecialData(worker1);
PrintPersonSpecialData(developer1);


void PrintPersonSpecialData(IPerson person)
{
    //Student worker = (Student)person;
    //Console.WriteLine(worker.Grade);

    
    if (person is Worker)
    {
        Worker worker = (Worker)person;
        Console.WriteLine(worker.Job);

        if (person is Developer)
        {
            Developer developer = (Developer)person;
            Console.WriteLine(developer.Experience);
        }
    }
    else if (person is Student)
    {
        Student student = (Student)person;
        Console.WriteLine(student.Grade);
    }
}



