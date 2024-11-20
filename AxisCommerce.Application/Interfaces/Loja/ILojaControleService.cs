using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Application.Interfaces.Loja;

public interface ILojaControleService
{
    Task AddAsync(LojaControle lojaControle);
    Task<LojaControle?> GetByIdAsync(Guid id);
    Task<IEnumerable<LojaControle>> GetAllAsync();
    Task UpdateAsync(LojaControle lojaControle);
    Task DeleteAsync(Guid id);
}
