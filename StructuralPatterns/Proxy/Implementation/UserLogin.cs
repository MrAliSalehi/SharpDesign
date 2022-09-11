namespace SharpDesign.StructuralPatterns.Proxy.Implementation;

public class UserLogin : UserLoginBase
{
    public override void Login(string username)
    {
        Console.WriteLine($"User: [{username}] logged-in.");
    }
}

public abstract class UserLoginBase
{
   public abstract void Login(string username);
}