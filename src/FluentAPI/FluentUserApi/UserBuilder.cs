using Highway.Data;
using Highway.Data.Contexts;

namespace FluentAPI.FluentUserApi;

public class UserBuilder : IBuildUsers
{
    private readonly IRepository _repository;

    public UserBuilder(IRepository repository)
    {
        _repository = repository;
    }

    public IBuildUserRoles CreateUser(string username)
    {
        return new UserRoleBuilder(_repository, username);
    }
}