using FluentAPI.FluentUserApi;
using FluentAssertions;
using Highway.Data;
using Highway.Data.Contexts;

namespace FluentAPI.Tests;

[TestFixture]
public class TestUserBuilderTests
{
    [Test]
    public void ExerciseFluentApi()
    {
        // In our code, this would be a real data context.
        var testContext = new InMemoryDataContext();

        // In our code, the repository would be a DomainRepository<TDomain>.
        var testRepository = new Repository(testContext);

        // The parameters need a lot of thinking, but this demonstrates the basic workflow.
        IBuildUsers testUserBuilder = new UserBuilder(testRepository);
        testUserBuilder.CreateUser("TestUserA")
            .InRole("TestRoleA")
            .WithApplicableEntitlements(ApplicableDataEntitlementTypes.All)
            .WithDataEntitlements(SecuredRoot.AssetGroup, 1, 2, 3)
            .WithDataEntitlements(SecuredRoot.PhysicalAsset, 4, 5, 6)
            .WithDataEntitlements(SecuredRoot.BusinessEntity, 7, 8, 9)
            .WithDataEntitlements(SecuredRoot.BusinessEntityAccount, 10, 11, 12)
            .Persist();

        // This just validates that I'm inserting stuff into the data context.
        var getUserByName = new GetUserByName("TestUserA");
        var user = testRepository.Find(getUserByName);
        user.UserRole.DataEntitlements.Should().HaveCountGreaterThan(0);
    }
}