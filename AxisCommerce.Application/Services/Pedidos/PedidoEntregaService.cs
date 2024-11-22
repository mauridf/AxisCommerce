using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class PedidoEntregaService : IPedidoEntregaService
{
    private readonly IPedidoEntregaRepository _pedidoEntregaRepository;

    public PedidoEntregaService(IPedidoEntregaRepository pedidoEntregaRepository)
    {
        _pedidoEntregaRepository = pedidoEntregaRepository;
    }

    public async Task AddAsync(PedidoEntrega pedidoEntrega)
    {
        await _pedidoEntregaRepository.AddAsync(pedidoEntrega);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _pedidoEntregaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PedidoEntrega>> GetAllAsync()
    {
        return await _pedidoEntregaRepository.GetAllAsync();
    }

    public async Task<PedidoEntrega?> GetByIdAsync(Guid id)
    {
        return await _pedidoEntregaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PedidoEntrega pedidoEntrega)
    {
        await _pedidoEntregaRepository.UpdateAsync(pedidoEntrega);
    }
}
