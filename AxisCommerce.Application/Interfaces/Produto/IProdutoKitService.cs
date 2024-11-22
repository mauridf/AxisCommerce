using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoKitService
{
    Task AddAsync(ProdutoKit produtoKit);
    Task<ProdutoKit?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoKit>> GetAllAsync();
    Task UpdateAsync(ProdutoKit produtoKit);
    Task DeleteAsync(Guid id);
}
