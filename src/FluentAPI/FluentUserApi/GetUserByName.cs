using Highway.Data;

namespace FluentAPI.FluentUserApi;

public class GetUserByName : Scalar<User>
{
    public GetUserByName(string username)
    {
        ContextQuery = dataSource => dataSource.AsQueryable<User>().Single(user => user.Username == username);
    }
}