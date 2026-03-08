using SalesFlow.Domain.Entities;
using SalesFlow.Domain.ValueObjects;
using SalesFlow.UnitTests.Commons;

namespace SalesFlow.UnitTests.Fakers;

public class ProductFaker: BaseFixture
{
    public  ProductFaker():base()
    {}

    public string GetValidName()
    {
        var name = "";
        while (name.Length < 3) name = Faker.Commerce.ProductName();
        return name.Length > 255 ? name[..255] : name;
    }

    public Product GetValidProduct()
    {
        var price = Faker.Commerce.Price();
        var money = new Money(Convert.ToDecimal(price));

        var name = GetValidName();
        return new Product(name, money);

    }

    public IEnumerable<object[]> GetInvalidNameWithThan3Characters(int numberOfTest = 6)
    {
        for (int i = 0; i < numberOfTest; i++)
        {
            var isOdd = i % 2 == 0;
            yield return new object[]
            {
                GetValidName()[..(isOdd ? 1 : 3)],
            };
        }
    }
   
}

[CollectionDefinition(nameof(ProductFaker))]
public class ProductTestFixtureCollection: ICollectionFixture<ProductFaker>{
}