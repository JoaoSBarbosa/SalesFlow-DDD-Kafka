using SalesFlow.Domain.Common;
using SalesFlow.Domain.Exceptions;
using SalesFlow.Domain.ValueObjects;

namespace SalesFlow.Domain.Entities;

public class Product: Entity
{
    public string Name { get; private set; } = string.Empty;
    public Money Price { get; private set; }

    public Product()
    {
    }

    public Product(string name, Money price)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new DomainException("Nome de produto inválido");
        
        Name = name;
        Price = price;

    }

   
}