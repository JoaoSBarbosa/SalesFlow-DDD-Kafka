using SalesFlow.UnitTests.Fakers;
using SalesFlow.UnitTests.Entities.Users;

namespace SalesFlow.UnitTests.Collections;

[CollectionDefinition(nameof(SaleTestFixtureCollection))]
public class SaleTestFixtureCollection: ICollectionFixture<ProductFaker>, ICollectionFixture<UserFaker>
{
    
}