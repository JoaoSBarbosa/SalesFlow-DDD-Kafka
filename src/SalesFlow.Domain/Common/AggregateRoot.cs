namespace SalesFlow.Domain.Common;

public abstract class AggregateRoot: Entity
{
    private readonly List<DomainEvent> _events = new();
    
    public IReadOnlyCollection<DomainEvent> Events => _events;

    protected void AddEvents(DomainEvent domainEvent) =>  _events.Add(domainEvent);

    protected void ClearEvents () => _events.Clear();
    
}