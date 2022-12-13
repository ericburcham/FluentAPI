using Highway.Data;

namespace FluentAPI.FluentUserApi;

public class ApplicableUserRoleEntitlementBuilder : IBuildApplicableUserRoleEntitlements
{
    private readonly IRepository _repository;
    private readonly string _role;
    private readonly string _username;

    public ApplicableUserRoleEntitlementBuilder(IRepository repository, string username, string role)
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