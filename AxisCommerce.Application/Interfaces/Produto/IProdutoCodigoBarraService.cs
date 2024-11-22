using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoCodigoBarraService
{
    Task AddAsync(ProdutoCodigoBarra produtoCodigoBarra);
    Task<ProdutoCodigoBarra?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoCodigoBarra>> GetAllAsync();
    Task UpdateAsync(ProdutoCodigoBarra produtoCodigoBarra);
    Task DeleteAsync(Guid id);
}
