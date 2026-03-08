using SalesFlow.Domain.Common;

namespace SalesFlow.Domain.Events;

public class SaleCreatedEvent: DomainEvent
{
    public Guid SaleId { get; }
    public decimal Total { get; }

    public SaleCreatedEvent(Guid saleId, decimal total)
    {
        SaleId = saleId;
        Total = total;
    }
}