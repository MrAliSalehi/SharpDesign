namespace SharpDesign.StructuralPatterns.Adapter.Implementation;

public class Rectangle : IRectangle
{
    private readonly double _len;
    private readonly double _width;
    public Rectangle(double width, double len)
    {
        _width = width;
        _len = len;
    }
    
    public void Print()
    {
        Console.WriteLine($"hello from {nameof(Rectangle)}");
    }

    public double CalcArea() => _len * _width;
}