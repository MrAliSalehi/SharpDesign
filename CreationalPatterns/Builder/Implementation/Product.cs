namespace SharpDesign.CreationalPatterns.Builder.Implementation;

public class Product
{
    private readonly List<string> _parts;

    internal Product()
    {
        _parts = new List<string>();
    }

    public void AddParts(string part)
    {
        _parts.Add(part);
    }

    public void Show()
    {
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}