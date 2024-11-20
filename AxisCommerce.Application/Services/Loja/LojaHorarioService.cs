using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;

namespace AxisCommerce.Application.Services.Lojas;

public class LojaHorarioService : ILojaHorarioService
{
    private readonly ILojaHorarioRepository _lojaHorarioRepository;

    public LojaHorarioService(ILojaHorarioRepository lojaHorarioRepository)
    {
        _lojaHorarioRepository = lojaHorarioRepository;
    }

    public async Task AddAsync(LojaHorario lojaHorario)
    {
        await _lojaHorarioRepository.AddAsync(lojaHorario);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _lojaHorarioRepository.DeleteAsync(id);
    }

    public Task<IEnumerable<LojaHorario>> GetAllAsync()
    {
        return _lojaHorarioRepository.GetAllAsync();
    }

    public Task<LojaHorario?> GetByIdAsync(Guid id)
    {
        return _lojaHorarioRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(LojaHorario lojaHorario)
    {
        await _lojaHorarioRepository.UpdateAsync(lojaHorario);
    }
}
