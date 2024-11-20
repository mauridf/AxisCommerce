using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IKitRepository
{
    Task AddAsync(Kit kit);
    Task<Kit?> GetByIdAsync(Guid id);
    Task<IEnumerable<Kit>> GetAllAsync();
    Task UpdateAsync(Kit kit);
    Task DeleteAsync(Guid id);
}
