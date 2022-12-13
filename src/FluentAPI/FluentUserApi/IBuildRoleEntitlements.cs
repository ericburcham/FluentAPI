namespace FluentAPI.FluentUserApi;

public interface IBuildRoleEntitlements
{
    public IBuildDataEntitlements WithApplicableEntitlements(
        ApplicableDataEntitlementTypes applicableDataEntitlementTypes);
}