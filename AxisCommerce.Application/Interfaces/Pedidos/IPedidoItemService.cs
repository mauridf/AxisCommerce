using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IPedidoItemService
{
    Task AddAsync(PedidoItem peditoItem);
    Task<PedidoItem?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoItem>> GetAllAsync();
    Task UpdateAsync(PedidoItem pedidoItem);
    Task DeleteAsync(Guid id);
}
