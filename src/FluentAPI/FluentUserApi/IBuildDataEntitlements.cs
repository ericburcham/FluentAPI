namespace FluentAPI.FluentUserApi;

public interface IBuildDataEntitlements
{
    public IBuildDataEntitlements WithDataEntitlements(SecuredRoot securedRoot, params long[] entitlements);

    public void Persist();
}