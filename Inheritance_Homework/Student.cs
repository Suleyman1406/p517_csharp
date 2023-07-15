
public class Student : Person
{
    public static int studentCount;
    private Teacher teacher;

    static Student()
    {
        studentCount = 0;
    }

    public Student(string name, string surname, int age, Teacher teacher) : base(name, surname, age)
    {
        studentCount++;
        this.Teacher = teacher;
    }

    public Teacher Teacher { get => teacher; set => teacher = value; }

    public override void PrintPersonInfo()
    {
        Console.WriteLine($"name: {Name}, surname: {Surname}, age: {Age}, job: Student");
    }

    public void PrintTeacherName()
    {
        Console.WriteLine($"{Name}'s teacher name is: {Teacher.Name}");
    }
}
