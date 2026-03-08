using FluentAssertions;
using SalesFlow.Domain.Exceptions;
using SalesFlow.Domain.ValueObjects;

namespace SalesFlow.UnitTests.ValueObjects;

public class MoneyTests
{


    [Fact(DisplayName = "Deve criar VO Money caso valor seja válido")]
    [Trait("ValueObject", "Money")]
    public void Should_Create_Money_With_Valid_Value()
    {
        var money = new Money(100);
        
        money.Value.Should().Be(100);
    }
    
    [Fact(DisplayName = ("Deve lançar exception quando valor for negativo"))]
    [Trait("ValueObject", "Money")]
    public void Should_Throw_Exception_When_Value_Is_Negative()
    {
        
        Action action = () => new Money(-100);

        action.Should().Throw<DomainException>();

    }
}