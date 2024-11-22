using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class PedidoPgtoService : IPedidoPagtoService
{
    private readonly IPedidoPagtoRepository _pedidoPagoRepository;

    public PedidoPgtoService(IPedidoPagtoRepository pedidoPagoRepository)
    {
        _pedidoPagoRepository = pedidoPagoRepository;
    }

    public async Task AddAsync(PedidoPagto pedidoPgto)
    {
        await _pedidoPagoRepository.AddAsync(pedidoPgto);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _pedidoPagoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PedidoPagto>> GetAllAsync()
    {
        return await _pedidoPagoRepository.GetAllAsync();
    }

    public async Task<PedidoPagto?> GetByIdAsync(Guid id)
    {
        return await _pedidoPagoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PedidoPagto pedidoPgto)
    {
        await _pedidoPagoRepository.UpdateAsync(pedidoPgto);
    }
}
