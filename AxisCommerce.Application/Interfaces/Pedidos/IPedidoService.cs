using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IPedidoService
{
    Task AddAsync(Pedido pedido);
    Task<Pedido?> GetByIdAsync(Guid id);
    Task<IEnumerable<Pedido>> GetAllAsync();
    Task UpdateAsync(Pedido pedido);
    Task DeleteAsync(Guid id);
}
