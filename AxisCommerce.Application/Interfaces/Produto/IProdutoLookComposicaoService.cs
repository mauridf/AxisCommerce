using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoLookComposicaoService
{
    Task AddAsync(ProdutoLookComposicao produtoLookComposicao);
    Task<ProdutoLookComposicao?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoLookComposicao>> GetAllAsync();
    Task UpdateAsync(ProdutoLookComposicao produtoLookComposicao);
    Task DeleteAsync(Guid id);
}
