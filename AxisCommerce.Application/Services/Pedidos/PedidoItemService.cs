using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class PedidoItemService : IPedidoItemService
{
    private readonly IPedidoItemRepository _itemRepository;

    public PedidoItemService(IPedidoItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public async Task AddAsync(PedidoItem peditoItem)
    {
        await _itemRepository.AddAsync(peditoItem);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _itemRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PedidoItem>> GetAllAsync()
    {
        return await _itemRepository.GetAllAsync();
    }

    public async Task<PedidoItem?> GetByIdAsync(Guid id)
    {
        return await _itemRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PedidoItem pedidoItem)
    {
        await _itemRepository.UpdateAsync(pedidoItem);
    }
}
