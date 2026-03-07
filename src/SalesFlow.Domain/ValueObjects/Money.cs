using SalesFlow.Domain.Exceptions;

namespace SalesFlow.Domain.ValueObjects;

public class Money
{
    public decimal Value { get; }

    public Money(decimal value)
    {
        if (value < 0) throw new DomainException("O preço não deve ser negativo");
        Value = value;
    }

    /*
     * Quando alguém fizer Money * int, cria um novo Money cujo valor sera Money.Value * int
     */
    public static Money operator *(Money money, int quantity)
    {
        return new Money(money.Value * quantity);
    }
}