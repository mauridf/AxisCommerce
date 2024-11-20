using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;

namespace AxisCommerce.Application.Services.Lojas;

public class TerminalService : ITerminalService
{
    private readonly ITerminalRepository _terminalRepository;

    public TerminalService(ITerminalRepository terminalRepository)
    {
        _terminalRepository = terminalRepository;
    }

    public async Task AddAsync(Terminal terminal)
    {
        await _terminalRepository.AddAsync(terminal);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _terminalRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Terminal>> GetAllAsync()
    {
        return await _terminalRepository.GetAllAsync();
    }

    public async Task<Terminal?> GetByCodTerminal(string codTerminal)
    {
        return await _terminalRepository.GetByCodTerminal(codTerminal);
    }

    public async Task<Terminal?> GetByIdAsync(Guid id)
    {
        return await _terminalRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Terminal terminal)
    {
        await _terminalRepository.UpdateAsync(terminal);
    }
}
