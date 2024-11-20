using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IPedidoPagtoRepository
{
    Task AddAsync(PedidoPagto pedidoPgto);
    Task<PedidoPagto?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoPagto>> GetAllAsync();
    Task UpdateAsync(PedidoPagto pedidoPgto);
    Task DeleteAsync(Guid id);
}
