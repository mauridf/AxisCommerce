using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface ITipoPedidoRepository
{
    Task AddAsync(TipoPedido tipoPedido);
    Task<TipoPedido?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoPedido>> GetAllAsync();
    Task UpdateAsync(TipoPedido tipoPedido);
    Task DeleteAsync(Guid id);
}
