namespace SharpDesign.CreationalPatterns.Singleton.Implementation;

public class MultiThreadSingleton
{
    private MultiThreadSingleton() { }

    private static volatile MultiThreadSingleton? _instance;
    private static readonly object LockObject = new();

    internal static MultiThreadSingleton GetInstance
    {
        get
        {
            lock (LockObject)
            {

                _instance = _instance ?? new MultiThreadSingleton();
            }

            return _instance;
        }
    }

    public void DoSomeJobs()
    {
        Console.WriteLine("Im NOT Singleton BTW");
    }
}