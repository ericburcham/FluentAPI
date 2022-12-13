namespace FluentAPI.FluentUserApi;

public class Role : Entity
{
    public Role(string name, ApplicableDataEntitlementTypes applicableDataEntitlementTypes)
    {
        Name = name;
        ApplicableDataEntitlementTypes = applicableDataEntitlementTypes;
    }

    public string Name { get; set; }
    public ApplicableDataEntitlementTypes ApplicableDataEntitlementTypes { get; set; }

    public UserRole UserRole { get; set; } = null!;

    internal void SetUserRole(UserRole userRole)
    {
        UserRole = userRole;
    }
}