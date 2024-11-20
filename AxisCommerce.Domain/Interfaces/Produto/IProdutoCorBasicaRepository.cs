using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoCorBasicaRepository
{
    Task AddAsync(ProdutoCorBasica produtoCorBasica);
    Task<ProdutoCorBasica?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoCorBasica>> GetAllAsync();
    Task UpdateAsync(ProdutoCorBasica produtoCorBasica);
    Task DeleteAsync(Guid id);
}
