using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface IPromocaoService
{
    Task AddAsync(Promocao promocao);
    Task<Promocao?> GetByIdAsync(Guid id);
    Task<IEnumerable<Promocao>> GetAllAsync();
    Task UpdateAsync(Promocao promocao);
    Task DeleteAsync(Guid id);
}
