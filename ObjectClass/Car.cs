using System;

public class Car
{
	private int age;
	public string name;
	private string model;
    public string Model
	{
		get
		{
			return model;
		}
		set
		{

			model = value;
		}
	}
	public static bool isActive;

	//public string name{ get; set; }


	static Car()
	{
		isActive = true;
	}

	//ctor
	public Car(string _name, int _age, string _model)
	{
		Console.WriteLine(isActive);
		name = _name;
		age = _age;
		model = _model;
    }

	public Car(string _name, int _age)
	{
        name = _name;
        age = _age;
        model = "NONE";
    }

    public int getAge()
	{
		return age;
	}

	public static void setActive(bool _isActive)
	{
		isActive = _isActive;
	}

	public void setAge(int _age)
	{
		if (_age >= 0) {
			age = _age;
		}
		else
		{
			throw new Exception("Age must be greater than 0");
		}
	}
}


