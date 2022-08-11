namespace SharpDesign.CreationalPatterns.Singleton.Implementation;

internal class Singleton
{
    //making ctor private,its optional
    private Singleton() { }

    // should be static
    internal static readonly Singleton Instance = new();

    public void DoSomeJobs()
    {
        Console.WriteLine("Im Singlethune with wrong spelling, rofl");
    }
}