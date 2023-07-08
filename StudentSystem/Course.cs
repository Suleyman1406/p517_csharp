using System;

public class Course
{
	private string name;
	private string description;
	private string startDate;

	public Course(string _name, string _description)
	{
		name = _name;
        description = _description;
    }

	public Course(string _name, string _description, string _startDate)
	{
        name = _name;
        description = _description;
        startDate = _startDate;
    }

	public void printCourseInfo()
	{
		Console.WriteLine($"Course name: {name}, course description: {description}");
	}
}


