using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IPedidoVendedorRepository
{
    Task AddAsync(PedidoVendedor pedidoVendedor);
    Task<PedidoVendedor?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoVendedor>> GetAllAsync();
    Task UpdateAsync(PedidoVendedor pedidoVendedor);
    Task DeleteAsync(Guid id);
}
