using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IEstoqueService
{
    Task AddAsync(Estoque estoque);
    Task<Estoque?> GetByIdAsync(Guid id);
    Task<IEnumerable<Estoque>> GetAllAsync();
    Task UpdateAsync(Estoque estoque);
    Task DeleteAsync(Guid id);
}
