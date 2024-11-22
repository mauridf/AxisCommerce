using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class PedidoService : IPedidoService
{
    private readonly IPedidoRepository _pedidoRepository;

    public PedidoService(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    public async Task AddAsync(Pedido pedido)
    {
        await _pedidoRepository.AddAsync(pedido);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _pedidoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Pedido>> GetAllAsync()
    {
        return await _pedidoRepository.GetAllAsync();
    }

    public async Task<Pedido?> GetByIdAsync(Guid id)
    {
        return await _pedidoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Pedido pedido)
    {
        await _pedidoRepository.UpdateAsync(pedido);
    }
}
