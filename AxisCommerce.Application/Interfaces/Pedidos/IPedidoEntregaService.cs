using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IPedidoEntregaService
{
    Task AddAsync(PedidoEntrega pedidoEntrega);
    Task<PedidoEntrega?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoEntrega>> GetAllAsync();
    Task UpdateAsync(PedidoEntrega pedidoEntrega);
    Task DeleteAsync(Guid id);
}
