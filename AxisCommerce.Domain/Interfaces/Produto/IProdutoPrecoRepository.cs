using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoPrecoRepository
{
    Task AddAsync(ProdutoPreco produtoPreco);
    Task<ProdutoPreco?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoPreco>> GetAllAsync();
    Task UpdateAsync(ProdutoPreco produtoPreco);
    Task DeleteAsync(Guid id);
}
