
public class UserExistsHandler : Handler
{
    private User user;
    public UserExistsHandler(User user)
    {
        this.user = user;
    }
    public override bool handle(string userName, string password, string role)
    {
        Console.WriteLine("UserExistsHandler Start");
        if (userName == user.UserName)
        {
            Console.WriteLine("User Exists Already. Please Try Again !!!");
            return false;
        }
        Console.WriteLine("UserExistsHandler Done");
        return handleNext(userName, password, role);
    }
}