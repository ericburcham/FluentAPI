using Highway.Data;

namespace FluentAPI.FluentUserApi;

public class DataEntitlementBuilder : IBuildDataEntitlements
{
    private readonly IRepository _repository;
    private readonly string _username;
    private readonly string _role;
    private readonly ApplicableDataEntitlementTypes _applicableDataEntitlementTypes;
    private readonly Dictionary<SecuredRoot,IEnumerable<long>> _dataEntitlements = new Dictionary<SecuredRoot, IEnumerable<long>>();

    public DataEntitlementBuilder(IRepository repository, string username, string role, ApplicableDataEntitlementTypes applicableDataEntitlementTypes)
    {
        _repository = repository;
        _username = username;
        _role = role;
        _applicableDataEntitlementTypes = applicableDataEntitlementTypes;
    }

    public IBuildDataEntitlements WithDataEntitlements(SecuredRoot securedRoot, params long[] entitlements)
    {
        _dataEntitlements.Add(securedRoot, entitlements);
        return this;
    }

    public void Persist()
    {
        var user = SaveUser();
        var role = SaveRole();
        SaveUserRole(user, role);
        SaveChanges();
    }

    private void SaveChanges()
    {
        _repository.Context.Commit();
    }

    private void SaveUserRole(User user, Role role)
    {
        var userRole = new UserRole(user, role);
        foreach (var dataEntitlement in _dataEntitlements)
        {
            userRole.AddEntitlement(dataEntitlement);
        }

        _repository.Context.Add(userRole);
    }

    private Role SaveRole()
    {
        var role = new Role(_role, _applicableDataEntitlementTypes);
        _repository.Context.Add(role);
        return role;
    }

    private User SaveUser()
    {
        var user = new User(_username);
        _repository.Context.Add(user);
        return user;
    }
}