public class User(string userName, string password, string role)
{
    public string UserName { get; set; } = userName;
    public string Password { get; set; } = password;
    public string Role { get; set; } = role;

    public override string ToString()
    {
        return String.Format($"UserName: {this.UserName} \nPassWord: {this.Password} \nRole: {role}");
    }
}