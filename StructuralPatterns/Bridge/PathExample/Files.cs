namespace SharpDesign.StructuralPatterns.Bridge.PathExample;

public abstract class Files
{
    public string FileName { get; set; } = default!;
    
    public abstract void SaveFile(string path);
    
}

public class TextFile : Files
{
    private IPath Path { get; set; }
    public TextFile(IPath path)
    {
        Path = path;
    }
    
    public override void SaveFile(string path)
    {
        var pathToSave = Path.GetPath(path);
        Console.WriteLine($"File Saved in :{pathToSave}");
    }
}