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

    public IBuildRoleEntitlements InRole(string role)
    {
        return new RoleEntitlementBuilder(_repository, _username, role);
    }
}