namespace SharpDesign.StructuralPatterns.Adapter.Implementation;

public class RectAdapter : IRectangle
{
    private readonly ITriangle _triangle;

    public RectAdapter(ITriangle triangle)
    {
        _triangle = triangle;
    }

    public void Print()
    {
        _triangle.PrintTriangle();
    }

    public double CalcArea() => _triangle.CalcAreaTriangle();
}