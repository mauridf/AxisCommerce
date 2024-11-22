using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class PedidoDescontoService : IPedidoDescontoService
{
    private readonly IPedidoDescontoRepository _pedidoDescontoRepository;

    public PedidoDescontoService(IPedidoDescontoRepository pedidoDescontoRepository)
    {
        _pedidoDescontoRepository = pedidoDescontoRepository;
    }

    public async Task AddAsync(PedidoDesconto pedidoDesconto)
    {
        await _pedidoDescontoRepository.AddAsync(pedidoDesconto);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _pedidoDescontoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PedidoDesconto>> GetAllAsync()
    {
        return await _pedidoDescontoRepository.GetAllAsync();
    }

    public async Task<PedidoDesconto?> GetByIdAsync(Guid id)
    {
        return await _pedidoDescontoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PedidoDesconto pedidoDesconto)
    {
        await _pedidoDescontoRepository.UpdateAsync(pedidoDesconto);
    }
}
