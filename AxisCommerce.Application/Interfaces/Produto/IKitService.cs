using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IKitService
{
    Task AddAsync(Kit kit);
    Task<Kit?> GetByIdAsync(Guid id);
    Task<IEnumerable<Kit>> GetAllAsync();
    Task UpdateAsync(Kit kit);
    Task DeleteAsync(Guid id);
}
