namespace SharpDesign.StructuralPatterns.Proxy.Implementation;

public class LoginProxy : UserLogin
{
    private readonly UserLogin _userLogin;
    public LoginProxy(UserLogin userLogin)
    {
        _userLogin = userLogin;
    }
    public override void Login(string username)
    {
        if (username is "admin")
            Console.WriteLine("welcome admin");

        _userLogin.Login(username);

        Console.WriteLine($"logged-in with {nameof(LoginProxy)}");
    }
}