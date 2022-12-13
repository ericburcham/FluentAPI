namespace FluentAPI.FluentUserApi;

public class User : Entity
{
    public string Username { get; set; }

    public User(string username)
    {
        Username = username;
    }

    internal void SetUserRole(UserRole userRole)
    {
        UserRole = userRole;
    }

    public UserRole UserRole { get; set; } = null!;
}