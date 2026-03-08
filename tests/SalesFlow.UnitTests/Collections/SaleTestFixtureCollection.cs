using SalesFlow.UnitTests.Entities.Products;
using SalesFlow.UnitTests.Entities.Users;

namespace SalesFlow.UnitTests.Collections;

[CollectionDefinition(nameof(SaleTestFixtureCollection))]
public class SaleTestFixtureCollection: ICollectionFixture<ProductTestFixture>, ICollectionFixture<UserFixture>
{
    
}