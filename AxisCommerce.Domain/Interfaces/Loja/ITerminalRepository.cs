using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Domain.Interfaces.Loja;

public interface ITerminalRepository
{
    Task AddAsync(Terminal terminal);
    Task<Terminal?> GetByIdAsync(Guid id);
    Task<Terminal?> GetByCodTerminal(string codTerminal);
    Task<IEnumerable<Terminal>> GetAllAsync();
    Task UpdateAsync(Terminal terminal);
    Task DeleteAsync(Guid id);
}
