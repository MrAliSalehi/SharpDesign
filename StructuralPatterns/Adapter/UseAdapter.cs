using SharpDesign.StructuralPatterns.Adapter.Implementation;

namespace SharpDesign.StructuralPatterns.Adapter;

public class UseAdapter
{
    public void AdapterInAction()
    {
        var rectangle = new Rectangle(15, 69);
        Console.WriteLine($"Area of {nameof(Rectangle)} was: {rectangle.CalcArea()}");

        var triangle = new Triangle(15, 69);
        Console.WriteLine($"Area of {nameof(Triangle)} was: {triangle.CalcAreaTriangle()}");

        var adapter = new RectAdapter(triangle);
        adapter.Print();

        Console.WriteLine($"Area of {nameof(RectAdapter)} using {nameof(triangle)} was : {adapter.CalcArea()}");
    }
}