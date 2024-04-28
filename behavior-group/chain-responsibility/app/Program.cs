using System;
using System.Runtime.InteropServices;
public class Program
{
    public static void Main()
    {
        var UserDatabase = new User("Test", "abc@123", "admin");
        var UserInput1 = new User("Test1", "abc@1235678", "guest");
        Handler handler = new UserExistsHandler(UserDatabase);
        handler.setNextHandler(new ValidPasswordHandler(UserDatabase)).setNextHandler(new ValidRoleHandler(UserDatabase));
        AuthService service = new AuthService(handler);
        service.Register(UserInput1.UserName, UserInput1.Password, UserInput1.Role);
    }
}