using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IPedidoRepository
{
    Task AddAsync(Pedido pedido);
    Task<Pedido?> GetByIdAsync(Guid id);
    Task<IEnumerable<Pedido>> GetAllAsync();
    Task UpdateAsync(Pedido pedido);
    Task DeleteAsync(Guid id);
}
