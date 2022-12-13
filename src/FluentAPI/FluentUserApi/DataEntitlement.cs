namespace FluentAPI.FluentUserApi;

public class DataEntitlement : Entity
{
    public DataEntitlement(SecuredRoot securedRoot, IEnumerable<long> entitlements)
    {
        SecuredRoot = securedRoot;
        Entitlements = entitlements;
    }

    public SecuredRoot SecuredRoot { get; set; }
    public IEnumerable<long> Entitlements { get; set; }
}