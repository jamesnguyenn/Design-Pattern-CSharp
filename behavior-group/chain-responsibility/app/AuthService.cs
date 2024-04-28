public class AuthService
{
    private Handler handler;
    public AuthService(Handler handler)
    {
        this.handler = handler;
    }
    public bool Register(string userName, string password, string role)
    {
        if (handler.handle(userName, password, role))
        {
            Console.WriteLine("Register Successfully");
            return true;
        }
        return false;
    }
}