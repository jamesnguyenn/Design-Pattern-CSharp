public class ValidPasswordHandler : Handler
{
    private User user;
    public ValidPasswordHandler(User user)
    {
        this.user = user;
    }
    public override bool handle(string userName, string password, string role)
    {
        Console.WriteLine("ValidPasswordHandler Start");
        if (password.Count() <= 8)
        {
            Console.WriteLine("Password Length <= 8. Please Try Again !!!");
            return false;
        }
        Console.WriteLine("ValidPasswordHandler Done");
        return handleNext(userName, password, role);
    }
}