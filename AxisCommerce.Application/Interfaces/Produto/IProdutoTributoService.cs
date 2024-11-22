using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoTributoService
{
    Task AddAsync(ProdutoTributo produtoTributo);
    Task<ProdutoTributo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoTributo>> GetAllAsync();
    Task UpdateAsync(ProdutoTributo produtoTributo);
    Task DeleteAsync(Guid id);
}
