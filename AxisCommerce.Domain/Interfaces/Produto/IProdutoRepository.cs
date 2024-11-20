using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoRepository
{
    Task AddAsync(Produto produto);
    Task<Produto?> GetByIdAsync(Guid id);
    Task<IEnumerable<Produto>> GetAllAsync();
    Task UpdateAsync(Produto produto);
    Task DeleteAsync(Guid id);
}
