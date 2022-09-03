namespace SharpDesign.StructuralPatterns.Bridge.PathExample;

public class LinuxPath : IPath
{
    public string GetPath(string where) => where.Replace(' ', '/').Replace('\\', '/');
}