
public class Student:Person
{
	public double Grade { get; set; }
	public Student(string name,double grade) : base(name)
	{
		this.Grade = grade;
	}


	public static explicit operator Teacher(Student student)
	{
		Teacher teacher = new Teacher(student.Name, 0);
		return teacher;
	}
}

