
public struct Triangle
{
    public int a;
    public int b;

    public Triangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public void CalculateArea()
    {
        Console.WriteLine($"area: {a*b}");
    }
}

