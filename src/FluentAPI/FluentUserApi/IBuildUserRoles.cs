namespace FluentAPI.FluentUserApi;

public interface IBuildUserRoles
{
    public IBuildRoleEntitlements InRole(string role);
}