using System;
using System.Threading;
public class Program
{
    public static void Main()
    {
        var thread1 = new Thread(() => User.GetInstance());
        var thread2 = new Thread(() => User.GetInstance());
        thread1.Start();
        thread2.Start();
    }
}

public class User
{
    public int Id { get; set; } = new Random().Next(0, 6);
    public string UserName { get; set; } = "Test";
    public string Password { get; set; } = "abc@123";
    public string Role { get; set; } = "role";

    private static readonly object lockObject = new object();
    private static User instance;


    public override string ToString()
    {
        return String.Format($"Id:{this.Id} \nUserName: {this.UserName} \nPassWord: {this.Password} \nRole: {this.Role}");
    }
    public static User GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new User();
            }
            Console.WriteLine(instance.ToString());
            Console.WriteLine("-----------------");
            return instance;
        }
    }
}