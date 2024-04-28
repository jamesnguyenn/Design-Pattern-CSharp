public class ValidRoleHandler : Handler
{
    private User user;
    public ValidRoleHandler(User user)
    {
        this.user = user;
    }
    public override bool handle(string userName, string password, string role)
    {
        Console.WriteLine("ValidRoleHandler Start");
        if (role != "admin")
        {
            Console.WriteLine("Role is invalid. Please Try Again !!!");
            return false;
        }
        Console.WriteLine("ValidRoleHandler Done");
        return handleNext(userName, password, role);
    }
}