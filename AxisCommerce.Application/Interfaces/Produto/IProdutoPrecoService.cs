using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoPrecoService
{
    Task AddAsync(ProdutoPreco produtoPreco);
    Task<ProdutoPreco?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoPreco>> GetAllAsync();
    Task UpdateAsync(ProdutoPreco produtoPreco);
    Task DeleteAsync(Guid id);
}
