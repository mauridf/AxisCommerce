using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using Microsoft.VisualBasic;

namespace AxisCommerce.Application.Services.Pedidos;

public class PedidoPromocaoService : IPedidoPromocaoService
{
    private readonly IPedidoPromocaoRepository _promocaoRepository;

    public PedidoPromocaoService(IPedidoPromocaoRepository promocaoRepository)
    {
        _promocaoRepository = promocaoRepository;
    }

    public async Task AddAsync(PedidoPromocao pedidoPromocao)
    {
        await _promocaoRepository.AddAsync(pedidoPromocao);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _promocaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PedidoPromocao>> GetAllAsync()
    {
        return await _promocaoRepository.GetAllAsync();
    }

    public async Task<PedidoPromocao?> GetByIdAsync(Guid id)
    {
        return await _promocaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PedidoPromocao pedidoPromocao)
    {
        await _promocaoRepository.UpdateAsync(pedidoPromocao);
    }
}
