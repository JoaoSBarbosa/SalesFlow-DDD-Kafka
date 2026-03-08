using FluentAssertions;
using SalesFlow.Domain.Entities;
namespace SalesFlow.UnitTests.Entities.Users;

[Collection(nameof(UserFaker))]
public class UserTest(UserFaker faker)
{

    private readonly UserFaker _faker = faker;
    
    [Fact(DisplayName = "Deve criar entidade user com dados válidos")]
    [Trait("Teste unitário ","User")]
    public void Should_Create_User_When_Valid_Fields()
    {
        var validUser = _faker.GetValidUser();
        
        var entity = new User(validUser.Name, validUser.Email);

        entity.Name.Should().Be(validUser.Name);
        entity.Email.Should().Be(validUser.Email);
        entity.Id.Should().NotBe(Guid.Empty);

    }
    
}