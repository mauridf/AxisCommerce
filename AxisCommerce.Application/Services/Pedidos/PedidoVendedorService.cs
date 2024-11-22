using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class PedidoVendedorService : IPedidoVendedorService
{
    private readonly IPedidoVendedorRepository _pedidoVendedorRepository;

    public PedidoVendedorService(IPedidoVendedorRepository pedidoVendedorRepository)
    {
        _pedidoVendedorRepository = pedidoVendedorRepository;
    }

    public async Task AddAsync(PedidoVendedor pedidoVendedor)
    {
        await _pedidoVendedorRepository.AddAsync(pedidoVendedor);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _pedidoVendedorRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PedidoVendedor>> GetAllAsync()
    {
        return await _pedidoVendedorRepository.GetAllAsync();
    }

    public async Task<PedidoVendedor?> GetByIdAsync(Guid id)
    {
        return await _pedidoVendedorRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PedidoVendedor pedidoVendedor)
    {
        await _pedidoVendedorRepository.UpdateAsync(pedidoVendedor);
    }
}
