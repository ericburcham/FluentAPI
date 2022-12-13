namespace FluentAPI.FluentUserApi;

public class UserRole : Entity
{
    public User User { get; set; }
    public Role Role { get; set; }

    public UserRole(User user, Role role)
    {
        User = user;
        Role = role;

        User.UserRole = this;
        Role.UserRole = this;
    }

    public void AddEntitlement(KeyValuePair<SecuredRoot,IEnumerable<long>> dataEntitlement)
    {
        DataEntitlements.Add(new DataEntitlement(dataEntitlement.Key, dataEntitlement.Value));
    }

    public List<DataEntitlement> DataEntitlements { get; set; } = new();
}