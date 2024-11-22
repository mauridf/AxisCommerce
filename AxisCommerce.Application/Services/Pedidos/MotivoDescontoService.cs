using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;

namespace AxisCommerce.Application.Services.Pedidos;

public class MotivoDescontoService : IMotivoDescontoService
{
    private readonly IMotivoDescontoRepository _motivoDescontoRepository;

    public MotivoDescontoService(IMotivoDescontoRepository motivoDescontoRepository)
    {
        _motivoDescontoRepository = motivoDescontoRepository;
    }

    public async Task AddAsync(MotivoDesconto motivoDesconto)
    {
        await _motivoDescontoRepository.AddAsync(motivoDesconto);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _motivoDescontoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<MotivoDesconto>> GetAllAsync()
    {
        return await _motivoDescontoRepository.GetAllAsync();
    }

    public async Task<MotivoDesconto?> GetByIdAsync(Guid id)
    {
        return await _motivoDescontoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(MotivoDesconto motivoDesconto)
    {
        await _motivoDescontoRepository.UpdateAsync(motivoDesconto);
    }
}
