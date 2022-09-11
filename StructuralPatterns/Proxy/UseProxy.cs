using SharpDesign.StructuralPatterns.Proxy.Implementation;

namespace SharpDesign.StructuralPatterns.Proxy;

public static class UseProxy
{
    public static void ProxyInAction()
    {
        //without proxy

        var login = new UserLogin();
        login.Login("akbar123");
        
        Console.WriteLine("-----proxy-----");
        //with proxy
        var proxy = new LoginProxy(login);
        proxy.Login("reza1234");
        proxy.Login("admin");
        
        //or

        Console.WriteLine("\nwithout passing the login object...");
        var proxy2 = new LoginProxy();
        proxy2.Login("admin");
        proxy2.Login("hashem2332");
    }
}