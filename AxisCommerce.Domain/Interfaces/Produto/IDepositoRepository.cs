using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IDepositoRepository
{
    Task AddAsync(Deposito deposito);
    Task<Deposito?> GetByIdAsync(Guid id);
    Task<IEnumerable<Deposito>> GetAllAsync();
    Task UpdateAsync(Deposito deposito);
    Task DeleteAsync(Guid id);
}
