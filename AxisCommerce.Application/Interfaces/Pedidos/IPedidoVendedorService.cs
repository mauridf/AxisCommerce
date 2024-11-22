using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IPedidoVendedorService
{
    Task AddAsync(PedidoVendedor pedidoVendedor);
    Task<PedidoVendedor?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoVendedor>> GetAllAsync();
    Task UpdateAsync(PedidoVendedor pedidoVendedor);
    Task DeleteAsync(Guid id);
}
