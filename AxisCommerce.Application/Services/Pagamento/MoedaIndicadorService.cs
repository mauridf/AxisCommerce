using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;

namespace AxisCommerce.Application.Services.Pagamento;

public class MoedaIndicadorService : IMoedaIndicadorService
{
    private readonly IMoedaIndicadorRepository _moedaIndicadorRepository;

    public MoedaIndicadorService(IMoedaIndicadorRepository moedaIndicadorRepository)
    {
        _moedaIndicadorRepository = moedaIndicadorRepository;
    }

    public async Task AddAsync(MoedaIndicador moedaIndicador)
    {
        await _moedaIndicadorRepository.AddAsync(moedaIndicador);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _moedaIndicadorRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<MoedaIndicador>> GetAllAsync()
    {
        return await _moedaIndicadorRepository.GetAllAsync();
    }

    public async Task<MoedaIndicador?> GetByIdAsync(Guid id)
    {
        return await _moedaIndicadorRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(MoedaIndicador moedaIndicador)
    {
        await _moedaIndicadorRepository.UpdateAsync(moedaIndicador);
    }
}
