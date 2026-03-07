using FluentAssertions;
using SalesFlow.Domain.Entities;
using SalesFlow.Domain.ValueObjects;
using SalesFlow.UnitTests.Entities.Products;

namespace SalesFlow.UnitTests.Entities.SalesItens;


[Collection(nameof(ProductTestFixture))]
public class SaleItemTest(ProductTestFixture  fixture)
{
    
    private readonly ProductTestFixture _productTestFixture = fixture;


    [Fact(DisplayName = "Deve instanciar um item")]
    [Trait("Teste unitário ", "Items produto")]
    public void Should_Create_Item_When_Valid_Values()
    {
        var product = _productTestFixture.GetValidProduct();
        var price = new Money(500);

        var validItem = new SaleItem(product.Id, 10, price);
        
        var item = new SaleItem(validItem.ProductId, validItem.Quantity, validItem.UnitPrice);
        
        
        item.Quantity.Should().Be(validItem.Quantity);
        item.UnitPrice.Should().Be(validItem.UnitPrice);
        item.ProductId.Should().Be(validItem.ProductId);
    }
    
}