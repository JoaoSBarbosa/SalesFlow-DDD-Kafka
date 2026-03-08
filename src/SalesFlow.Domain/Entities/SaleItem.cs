using SalesFlow.Domain.Common;
using SalesFlow.Domain.Exceptions;
using SalesFlow.Domain.ValueObjects;

namespace SalesFlow.Domain.Entities;

public class SaleItem: Entity
{

    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public Money UnitPrice { get; private set; }
    public decimal Total => UnitPrice.Value * Quantity;

    public SaleItem(Guid productId, int quantity, Money unitPrice)
    {
        if ( quantity <=0) throw new DomainException("Quantidade deve ser maior que 0.");
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}