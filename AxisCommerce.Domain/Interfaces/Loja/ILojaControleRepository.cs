using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Domain.Interfaces.Loja;

public interface ILojaControleRepository
{
    Task AddAsync(LojaControle lojaControle);
    Task<LojaControle?> GetByIdAsync(Guid id);
    Task<IEnumerable<LojaControle>> GetAllAsync();
    Task UpdateAsync(LojaControle lojaControle);
    Task DeleteAsync(Guid id);
}
