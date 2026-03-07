using FluentAssertions;
using SalesFlow.Domain.Entities;
using SalesFlow.Domain.ValueObjects;
using SalesFlow.UnitTests.Entities.Products;

namespace SalesFlow.UnitTests.Entities.Products;

[Collection(nameof(ProductTestFixture))]
public class ProductTest(ProductTestFixture  fixture)
{

    private readonly ProductTestFixture _productTestFixture = fixture;
    
    
    [Fact(DisplayName = "Deve instanciar um produto válido")]
    [Trait("Teste unitário", "Produto")]
    public void Should_Create_Product_When_Valid_Values()
    {
        var validProduct = _productTestFixture.GetValidProduct();
        var product = new Product(validProduct.Name, validProduct.Price);
   

        product.Name.Should().Be(validProduct.Name);
        product.Price.Should().Be(validProduct.Price);

    }
}