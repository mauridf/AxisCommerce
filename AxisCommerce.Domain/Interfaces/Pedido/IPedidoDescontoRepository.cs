using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IPedidoDescontoRepository
{
    Task AddAsync(PedidoDesconto pedidoDesconto);
    Task<PedidoDesconto?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoDesconto>> GetAllAsync();
    Task UpdateAsync(PedidoDesconto pedidoDesconto);
    Task DeleteAsync(Guid id);
}
