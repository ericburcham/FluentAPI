namespace FluentAPI.FluentUserApi;

public class User : Entity
{
    public User(string username)
    {
        Username = username;
    }

    public string Username { get; set; }

    public UserRole UserRole { get; set; } = null!;

    internal void SetUserRole(UserRole userRole)
    {
        UserRole = userRole;
    }
}