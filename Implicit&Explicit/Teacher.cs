
public class Teacher:Person
{
	public int Experience { get; set; }

	public Teacher(string name, int expericen) : base(name)
	{
		this.Experience = expericen;
	}

	public static implicit operator Student(Teacher teacher)
	{
		Student student = new Student(teacher.Name,0);
		return student;
	}

}

