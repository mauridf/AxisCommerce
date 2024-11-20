using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Loja;

public class TerminalRepository : ITerminalRepository
{
    private readonly ApplicationDbContext _context;

    public TerminalRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Terminal terminal)
    {
        await _context.Set<Terminal>().AddAsync(terminal);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var terminal = await GetByIdAsync(id);
        if(terminal != null)
        {
            _context.Set<Terminal>().Remove(terminal);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Terminal>> GetAllAsync()
    {
        return await _context.Set<Terminal>().ToListAsync();
    }

    public async Task<Terminal?> GetByCodTerminal(string codTerminal)
    {
        return await _context.Set<Terminal>().FindAsync(codTerminal);
    }

    public async Task<Terminal?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Terminal>().FindAsync(id);
    }

    public async Task UpdateAsync(Terminal terminal)
    {
        _context.Set<Terminal>().Update(terminal);
        await _context.SaveChangesAsync() ;
    }
}
