using SalesFlow.Domain.Entities;
using SalesFlow.UnitTests.Commons;

namespace SalesFlow.UnitTests.Entities.Users;

public class UserFixture: BaseFixture
{


    public User GetValidUser()
    {
        return new User(GetValidUsername(), GetValidEmail());
    }


    public string GetValidEmail()
    {
        var email = "";
        while (email.Length < 3) email = Faker.Internet.Email();
        return email.Length > 255 ? email[..255] : email;
    }

    public string GetValidUsername()
    {
        var name = "";
        while (name.Length < 3) name = Faker.Name.FirstName();
        return name.Length > 255 ? name[..255] : name;
    }
}

[CollectionDefinition(nameof(UserFixture))]
public class GetValidEmailCollection: ICollectionFixture<UserFixture> {}