using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IPedidoPromocaoService
{
    Task AddAsync(PedidoPromocao pedidoPromocao);
    Task<PedidoPromocao?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoPromocao>> GetAllAsync();
    Task UpdateAsync(PedidoPromocao pedidoPromocao);
    Task DeleteAsync(Guid id);
}
