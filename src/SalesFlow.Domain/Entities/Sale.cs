using SalesFlow.Domain.Common;
using SalesFlow.Domain.Events;
using SalesFlow.Domain.ValueObjects;

namespace SalesFlow.Domain.Entities;

public class Sale: AggregateRoot
{

    public Guid UserId { get; private set; }
    public DateTime Date { get; private set; }
    private readonly List<SaleItem> _items = new();
    public IReadOnlyCollection<SaleItem> Items => _items;

    public decimal Total => _items.Sum(x => x.Total);

    public Sale(Guid userId)
    {
        UserId = userId;
        Date = DateTime.UtcNow;
    }

    public void AddItem(Guid productId, int quantity, Money price)
    {
        var item = new SaleItem(productId, quantity, price);
        _items.Add(item);
    }

    public void Confirm()=> AddEvents(new SaleCreatedEvent(Id, Total));
    
}