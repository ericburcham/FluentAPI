namespace FluentAPI.FluentUserApi;

public class UserRole : Entity
{
    public UserRole(User user, Role role)
    {
        User = user;
        Role = role;

        User.UserRole = this;
        Role.UserRole = this;
    }

    public User User { get; set; }
    public Role Role { get; set; }

    public List<DataEntitlement> DataEntitlements { get; set; } = new();

    public void AddEntitlement(KeyValuePair<SecuredRoot, IEnumerable<long>> dataEntitlement)
    {
        DataEntitlements.Add(new DataEntitlement(dataEntitlement.Key, dataEntitlement.Value));
    }
}