using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IPedidoPagtoService
{
    Task AddAsync(PedidoPagto pedidoPgto);
    Task<PedidoPagto?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoPagto>> GetAllAsync();
    Task UpdateAsync(PedidoPagto pedidoPgto);
    Task DeleteAsync(Guid id);
}
