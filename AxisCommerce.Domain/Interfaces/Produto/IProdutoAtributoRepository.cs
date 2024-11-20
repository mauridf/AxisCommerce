using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoAtributoRepository
{
    Task AddAsync(ProdutoAtributo produtoAtributo);
    Task<ProdutoAtributo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoAtributo>> GetAllAsync();
    Task UpdateAsync(ProdutoAtributo produtoAtributo);
    Task DeleteAsync(Guid id);
}
