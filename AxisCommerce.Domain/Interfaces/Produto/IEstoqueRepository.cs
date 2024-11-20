using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IEstoqueRepository
{
    Task AddAsync(Estoque estoque);
    Task<Estoque?> GetByIdAsync(Guid id);
    Task<IEnumerable<Estoque>> GetAllAsync();
    Task UpdateAsync(Estoque estoque);
    Task DeleteAsync(Guid id);
}
