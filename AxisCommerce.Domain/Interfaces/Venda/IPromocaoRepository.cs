using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface IPromocaoRepository
{
    Task AddAsync(Promocao promocao);
    Task<Promocao?> GetByIdAsync(Guid id);
    Task<IEnumerable<Promocao>> GetAllAsync();
    Task UpdateAsync(Promocao promocao);
    Task DeleteAsync(Guid id);
}
