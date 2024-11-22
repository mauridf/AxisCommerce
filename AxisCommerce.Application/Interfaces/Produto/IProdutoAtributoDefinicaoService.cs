using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoAtributoDefinicaoService
{
    Task AddAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao);
    Task<ProdutoAtributoDefinicao?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoAtributoDefinicao>> GetAllAsync();
    Task UpdateAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao);
    Task DeleteAsync(Guid id);
}
