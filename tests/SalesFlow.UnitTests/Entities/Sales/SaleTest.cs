using FluentAssertions;
using SalesFlow.Domain.Entities;
using SalesFlow.UnitTests.Collections;
using SalesFlow.UnitTests.Fakers;
using SalesFlow.UnitTests.Entities.Users;

namespace SalesFlow.UnitTests.Entities.Sales;


[Collection(nameof(SaleTestFixtureCollection))]
public class SaleTest(ProductFaker fixture, UserFaker userFaker)
{

    private readonly ProductFaker _productFaker = fixture;
    private readonly UserFaker _userFaker = userFaker;
    
    [Fact(DisplayName = "Deve criar entidade Venda com dados válidos")]
    [Trait("Teste unitário ", "Sale")]
    public void Should_Create_Sale_When_Valid_Values()
    {
        var product1 = _productFaker.GetValidProduct();
        var product2 = _productFaker.GetValidProduct();

        var product1Quantity = 25;
        var product2Quantity = 5;
        
        var user = _userFaker.GetValidUser();
        var sale = new Sale(user.Id);
        
        sale.AddItem(product1.Id, product1Quantity, product1.Price);
        sale.AddItem(product2.Id, product2Quantity, product2.Price);

        var total = (product1.Price.Value * product1Quantity) + ( product2.Price.Value * product2Quantity);
        
        sale.Total.Should().Be(total);
        sale.Items.Should().HaveCount(2);
    }
}