using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IProdutoCatalogoService
{
    Task AddAsync(ProdutoCatalogo produtoCatalogo);
    Task<ProdutoCatalogo?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProdutoCatalogo>> GetAllAsync();
    Task UpdateAsync(ProdutoCatalogo produtoCatalogo);
    Task DeleteAsync(Guid id);
}
