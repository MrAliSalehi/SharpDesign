namespace SharpDesign.StructuralPatterns.Adapter.Implementation;

public class Triangle : ITriangle
{
    private readonly double _len;
    private readonly double _height;

    public Triangle(double height, double len)
    {
        _height = height;
        _len = len;
    }

    public void PrintTriangle()
    {
        Console.WriteLine($"Hello From {nameof(Triangle)}");
    }

    public double CalcAreaTriangle() => .5  * _len * _height;
}