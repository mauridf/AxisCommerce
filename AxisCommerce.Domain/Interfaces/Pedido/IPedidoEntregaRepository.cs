using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IPedidoEntregaRepository
{
    Task AddAsync(PedidoEntrega pedidoEntrega);
    Task<PedidoEntrega?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoEntrega>> GetAllAsync();
    Task UpdateAsync(PedidoEntrega pedidoEntrega);
    Task DeleteAsync(Guid id);
}
