Person person = new Student();
Person person1 = new Person();


Any(person);


void Any(Person person)
{
    //if (person is Student)
    //{
        //Student student = (Student)person;
    //    student.A();
    //}

    Student student = person as Student;

    if (student != null)
    {
        student.A();
    }
}







