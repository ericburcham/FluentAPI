using Highway.Data;

namespace FluentAPI.FluentUserApi;

public class UserRoleBuilder : IBuildUserRoles
{
    private readonly IRepository _repository;
    private readonly string _username;

    internal UserRoleBuilder(IRepository repository, string username)
    {
        _repository = repository;
        _username = username;
    }

    public IBuildApplicableUserRoleEntitlements InRole(string role)
    {
        return new ApplicableUserRoleEntitlementBuilder(_repository, _username, role);
    }
}