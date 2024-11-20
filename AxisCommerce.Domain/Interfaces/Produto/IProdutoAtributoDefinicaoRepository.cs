using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoAtributoDefinicaoRepository
{
    Task AddAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao);
    Task<ProdutoAtributoDefinicao?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoAtributoDefinicao>> GetAllAsync();
    Task UpdateAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao);
    Task DeleteAsync(Guid id);
}
