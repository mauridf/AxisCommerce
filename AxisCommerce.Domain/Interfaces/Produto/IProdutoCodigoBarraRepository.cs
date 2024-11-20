using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoCodigoBarraRepository
{
    Task AddAsync(ProdutoCodigoBarra produtoCodigoBarra);
    Task<ProdutoCodigoBarra?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoCodigoBarra>> GetAllAsync();
    Task UpdateAsync(ProdutoCodigoBarra produtoCodigoBarra);
    Task DeleteAsync(Guid id);
}
