using FluentAssertions;
using SalesFlow.Domain.Entities;
using SalesFlow.UnitTests.Fakers;

namespace SalesFlow.UnitTests.Entities.Products;

[Collection(nameof(ProductFaker))]
public class ProductTest(ProductFaker  fixture)
{

    private readonly ProductFaker _productFaker = fixture;
    
    
    [Fact(DisplayName = "Deve instanciar um produto válido")]
    [Trait("Teste unitário", "Produto")]
    public void Should_Create_Product_When_Valid_Values()
    {
        var validProduct = _productFaker.GetValidProduct();
        var product = new Product(validProduct.Name, validProduct.Price);
   

        product.Name.Should().Be(validProduct.Name);
        product.Price.Should().Be(validProduct.Price);

    }
}