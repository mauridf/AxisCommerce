using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IMotivoDescontoService
{
    Task AddAsync(MotivoDesconto motivoDesconto);
    Task<MotivoDesconto?> GetByIdAsync(Guid id);
    Task<IEnumerable<MotivoDesconto>> GetAllAsync();
    Task UpdateAsync(MotivoDesconto motivoDesconto);
    Task DeleteAsync(Guid id);
}
