using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoAtributoService
{
    Task AddAsync(ProdutoAtributo produtoAtributo);
    Task<ProdutoAtributo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoAtributo>> GetAllAsync();
    Task UpdateAsync(ProdutoAtributo produtoAtributo);
    Task DeleteAsync(Guid id);
}
