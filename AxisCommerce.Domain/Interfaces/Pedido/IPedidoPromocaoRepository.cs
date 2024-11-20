using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IPedidoPromocaoRepository
{
    Task AddAsync(PedidoPromocao pedidoPromocao);
    Task<PedidoPromocao?> GetByIdAsync(Guid id);
    Task<IEnumerable<PedidoPromocao>> GetAllAsync();
    Task UpdateAsync(PedidoPromocao pedidoPromocao);
    Task DeleteAsync(Guid id);
}
