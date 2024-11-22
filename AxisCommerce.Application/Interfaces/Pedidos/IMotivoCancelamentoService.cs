using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IMotivoCancelamentoService
{
    Task AddAsync(MotivoCancelamento motivoCancelamento);
    Task<MotivoCancelamento?> GetByIdAsync(Guid id);
    Task<IEnumerable<MotivoCancelamento>> GetAllAsync();
    Task UpdateAsync(MotivoCancelamento motivoCancelamento);
    Task DeleteAsync(Guid id);
}
