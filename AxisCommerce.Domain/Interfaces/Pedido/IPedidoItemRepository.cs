using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IPedidoItemRepository
{
    Task AddAsync(PedidoItem peditoItem);
    Task<PedidoItem?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoItem>> GetAllAsync();
    Task UpdateAsync(PedidoItem pedidoItem);
    Task DeleteAsync(Guid id);
}
