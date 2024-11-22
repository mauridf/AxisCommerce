using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class MotivoCancelamentoService : IMotivoCancelamentoService
{
    private readonly IMotivoCancelamentoRepository _motivoCancelamentoRepository;

    public MotivoCancelamentoService(IMotivoCancelamentoRepository motivoCancelamentoRepository)
    {
        _motivoCancelamentoRepository = motivoCancelamentoRepository;
    }

    public async Task AddAsync(MotivoCancelamento motivoCancelamento)
    {
        await _motivoCancelamentoRepository.AddAsync(motivoCancelamento);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _motivoCancelamentoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<MotivoCancelamento>> GetAllAsync()
    {
        return await _motivoCancelamentoRepository.GetAllAsync();
    }

    public async Task<MotivoCancelamento?> GetByIdAsync(Guid id)
    {
        return await _motivoCancelamentoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(MotivoCancelamento motivoCancelamento)
    {
        await _motivoCancelamentoRepository.UpdateAsync(motivoCancelamento);
    }
}
