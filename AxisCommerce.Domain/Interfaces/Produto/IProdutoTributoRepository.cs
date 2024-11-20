using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;
public interface IProdutoTributoRepository
{
    Task AddAsync(ProdutoTributo produtoTributo);
    Task<ProdutoTributo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoTributo>> GetAllAsync();
    Task UpdateAsync(ProdutoTributo produtoTributo);
    Task DeleteAsync(Guid id);
}
