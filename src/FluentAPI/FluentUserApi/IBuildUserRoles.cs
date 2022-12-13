namespace FluentAPI.FluentUserApi;

public interface IBuildUserRoles
{
    public IBuildApplicableUserRoleEntitlements InRole(string role);
}