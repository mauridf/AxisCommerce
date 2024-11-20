using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoLookComposicaoRepository
{
    Task AddAsync(ProdutoLookComposicao produtoLookComposicao);
    Task<ProdutoLookComposicao?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoLookComposicao>> GetAllAsync();
    Task UpdateAsync(ProdutoLookComposicao produtoLookComposicao);
    Task DeleteAsync(Guid id);
}
