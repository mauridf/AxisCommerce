using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class TipoPedidoService : ITipoPedidoService
{
    private readonly ITipoPedidoRepository _tipoPedidoRepository;

    public TipoPedidoService(ITipoPedidoRepository tipoPedidoRepository)
    {
        _tipoPedidoRepository = tipoPedidoRepository;
    }

    public async Task AddAsync(TipoPedido tipoPedido)
    {
        await _tipoPedidoRepository.AddAsync(tipoPedido);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _tipoPedidoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<TipoPedido>> GetAllAsync()
    {
        return await _tipoPedidoRepository.GetAllAsync();
    }

    public async Task<TipoPedido?> GetByIdAsync(Guid id)
    {
        return await _tipoPedidoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(TipoPedido tipoPedido)
    {
        await _tipoPedidoRepository.UpdateAsync(tipoPedido);
    }
}
