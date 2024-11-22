using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;

namespace AxisCommerce.Application.Services.Pagamento;

public class ProgramaFidelidadeService : IProgramaFidelidadeService
{
    private readonly IProgramaFidelidadeRepository _programaFidelidadeRepository;

    public ProgramaFidelidadeService(IProgramaFidelidadeRepository programaFidelidadeRepository)
    {
        _programaFidelidadeRepository = programaFidelidadeRepository;
    }

    public async Task AddAsync(ProgramaFidelidade programaFidelidade)
    {
        await _programaFidelidadeRepository.AddAsync(programaFidelidade);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _programaFidelidadeRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProgramaFidelidade>> GetAllAsync()
    {
        return await _programaFidelidadeRepository.GetAllAsync();
    }

    public async Task<ProgramaFidelidade?> GetByIdAsync(Guid id)
    {
        return await _programaFidelidadeRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProgramaFidelidade programaFidelidade)
    {
        await _programaFidelidadeRepository.UpdateAsync(programaFidelidade);
    }
}
