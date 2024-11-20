using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IMotivoDescontoRepository
{
    Task AddAsync(MotivoDesconto motivoDesconto);
    Task<MotivoDesconto?> GetByIdAsync(Guid id);
    Task<IEnumerable<MotivoDesconto>> GetAllAsync();
    Task UpdateAsync(MotivoDesconto motivoDesconto);
    Task DeleteAsync(Guid id);
}
