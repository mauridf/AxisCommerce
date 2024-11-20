using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IProdutoCatalogoRepository
{
    Task AddAsync(ProdutoCatalogo produtoCatalogo);
    Task<ProdutoCatalogo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoCatalogo>> GetAllAsync();
    Task UpdateAsync(ProdutoCatalogo produtoCatalogo);
    Task DeleteAsync(Guid id);
}
