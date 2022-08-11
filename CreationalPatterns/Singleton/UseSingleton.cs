using SharpDesign.CreationalPatterns.Singleton.Implementation;

namespace SharpDesign.CreationalPatterns.Singleton;

public class UseSingleton
{
    public void PatternInAction()
    {
        //no more new Singleton();
        //only one instance, its cool,isn't it ?
        Implementation.Singleton.Instance.DoSomeJobs();

        //multi threading ? do this :
        MultiThreadSingleton.GetInstance.DoSomeJobs();
    }
}