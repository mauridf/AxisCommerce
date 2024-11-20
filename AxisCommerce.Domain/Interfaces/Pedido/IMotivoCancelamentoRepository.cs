using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IMotivoCancelamentoRepository
{
    Task AddAsync(MotivoCancelamento motivoCancelamento);
    Task<MotivoCancelamento?> GetByIdAsync(Guid id);
    Task<IEnumerable<MotivoCancelamento>> GetAllAsync();
    Task UpdateAsync(MotivoCancelamento motivoCancelamento);
    Task DeleteAsync(Guid id);
}
