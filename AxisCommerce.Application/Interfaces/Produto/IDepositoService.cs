using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IDepositoService
{
    Task AddAsync(Deposito deposito);
    Task<Deposito?> GetByIdAsync(Guid id);
    Task<IEnumerable<Deposito>> GetAllAsync();
    Task UpdateAsync(Deposito deposito);
    Task DeleteAsync(Guid id);
}
