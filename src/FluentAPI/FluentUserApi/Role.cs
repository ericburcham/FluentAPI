namespace FluentAPI.FluentUserApi;

public class Role : Entity
{
    public string Name { get; set; }
    public ApplicableDataEntitlementTypes ApplicableDataEntitlementTypes { get; set; }

    public Role(string name, ApplicableDataEntitlementTypes applicableDataEntitlementTypes)
    {
        Name = name;
        ApplicableDataEntitlementTypes = applicableDataEntitlementTypes;
    }

    internal void SetUserRole(UserRole userRole)
    {
        UserRole = userRole;
    }

    public UserRole UserRole { get; set; } = null!;
}