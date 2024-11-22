using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface ITipoPedidoService
{
    Task AddAsync(TipoPedido tipoPedido);
    Task<TipoPedido?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoPedido>> GetAllAsync();
    Task UpdateAsync(TipoPedido tipoPedido);
    Task DeleteAsync(Guid id);
}
