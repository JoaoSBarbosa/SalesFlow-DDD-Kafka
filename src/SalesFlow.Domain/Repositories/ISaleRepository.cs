using SalesFlow.Domain.Entities;

namespace SalesFlow.Domain.Repositories;

public interface ISaleRepository
{
    Task AddAsync(Sale sale);
    Task<Sale?> GetById(Guid saleId);
    Task<IEnumerable<Sale>> GetAllAsync();
}