namespace FluentAPI.FluentUserApi;

public interface IBuildUsers
{
    public IBuildUserRoles CreateUser(string username);
}