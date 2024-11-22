using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IPedidoDescontoService
{
    Task AddAsync(PedidoDesconto pedidoDesconto);
    Task<PedidoDesconto?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoDesconto>> GetAllAsync();
    Task UpdateAsync(PedidoDesconto pedidoDesconto);
    Task DeleteAsync(Guid id);
}
