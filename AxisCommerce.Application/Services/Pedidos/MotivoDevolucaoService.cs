using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class MotivoDevolucaoService : IMotivoDevolucaoService
{
    private readonly IMotivoDevolucaoRepository _motivoDevolucaoRepository;

    public MotivoDevolucaoService(IMotivoDevolucaoRepository motivoDevolucaoRepository)
    {
        _motivoDevolucaoRepository = motivoDevolucaoRepository;
    }

    public async Task AddAsync(MotivoDevolucao motivoDevolucao)
    {
        await _motivoDevolucaoRepository.AddAsync(motivoDevolucao);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _motivoDevolucaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<MotivoDevolucao>> GetAllAsync()
    {
        return await _motivoDevolucaoRepository.GetAllAsync();
    }

    public async Task<MotivoDevolucao?> GetByIdAsync(Guid id)
    {
        return await _motivoDevolucaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(MotivoDevolucao motivoDevolucao)
    {
        await _motivoDevolucaoRepository.UpdateAsync(motivoDevolucao);
    }
}
