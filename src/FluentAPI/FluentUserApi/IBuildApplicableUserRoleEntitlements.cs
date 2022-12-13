namespace FluentAPI.FluentUserApi;

public interface IBuildApplicableUserRoleEntitlements
{
    public IBuildDataEntitlements WithApplicableEntitlements(
        ApplicableDataEntitlementTypes applicableDataEntitlementTypes);
}