using Highway.Data;

namespace FluentAPI.FluentUserApi;

public class RoleEntitlementBuilder : IBuildRoleEntitlements
{
    private readonly IRepository _repository;
    private readonly string _role;
    private readonly string _username;

    public RoleEntitlementBuilder(IRepository repository, string username, string role)
    {
        _repository = repository;
        _username = username;
        _role = role;
    }

    public IBuildDataEntitlements WithApplicableEntitlements(
        ApplicableDataEntitlementTypes applicableDataEntitlementTypes)
    {
        return new DataEntitlementBuilder(_repository, _username, _role, applicableDataEntitlementTypes);
    }
}