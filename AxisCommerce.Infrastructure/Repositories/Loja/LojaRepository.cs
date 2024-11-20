using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Loja;

public class LojaRepository : ILojaRepository
{
    private readonly ApplicationDbContext _context;

    public LojaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Lojas loja)
    {
        await _context.Set<Lojas>().AddAsync(loja);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var loja = await GetByIdAsync(id);
        if (loja != null)
        {
            _context.Set<Lojas>().Remove(loja);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Lojas>> GetAllAsync()
    {
        return await _context.Set<Lojas>().ToListAsync();
    }

    public async Task<Lojas?> GetByCodLoja(string codLoja)
    {
        return await _context.Set<Lojas>().FindAsync(codLoja);
    }

    public async Task<Lojas?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Lojas>().FindAsync(id);
    }

    public async Task UpdateAsync(Lojas loja)
    {
        _context.Set<Lojas>().Update(loja);
        await _context.SaveChangesAsync();
    }
}
