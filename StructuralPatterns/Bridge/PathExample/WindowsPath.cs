namespace SharpDesign.StructuralPatterns.Bridge.PathExample;

public class WindowsPath : IPath
{
    public string GetPath(string where) => where.Replace(' ', '\\').Replace('/', '\\');
}