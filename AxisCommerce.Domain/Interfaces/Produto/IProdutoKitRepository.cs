using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoKitRepository
{
    Task AddAsync(ProdutoKit produtoKit);
    Task<ProdutoKit?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoKit>> GetAllAsync();
    Task UpdateAsync(ProdutoKit produtoKit);
    Task DeleteAsync(Guid id);
}
