using System;

public class Student
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
	private string surname;
    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }
	private double[] scores;
	private Course course;


    public Student(string _name, string _surname)
	{
		scores = new double[3];
		name = _name;
		surname = _surname;
	}

    public Student(string _name, string _surname, Course _course)
    {
        scores = new double[3];
        name = _name;
        surname = _surname;
		course = _course;
    }

    public Course getCourse()
	{
		return course;
	}

	public void setCourse(Course _course)
	{
		course = _course;
	}

	public double[] getScores()
	{
		return scores;
	}

	public double getAvarage()
	{
		return scores[0]*0.3 + scores[1] * 0.3 + scores[2]*0.4;
	}

	public void setScores(double midterm, double midterm2, double final)
	{
		if(midterm< 0 || midterm>100 || midterm2 < 0 || midterm2 > 100 || final < 0 || final > 100)
		{
			throw new Exception("Score must be valid");
		}

		scores[0] = midterm;
		scores[1] = midterm2;
		scores[2] = final;
;	}

}

