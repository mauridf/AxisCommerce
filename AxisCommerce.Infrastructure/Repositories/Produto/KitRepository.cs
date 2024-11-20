using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class KitRepository : IKitRepository
{
    private readonly ApplicationDbContext _context;

    public KitRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Kit kit)
    {
        _context.Set<Kit>().Add(kit);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var kit = await GetByIdAsync(id);
        if(kit != null)
        {
            _context.Set<Kit>().Remove(kit);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Kit>> GetAllAsync()
    {
        return await _context.Set<Kit>().ToListAsync();
    }

    public async Task<Kit?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Kit>().FindAsync(id);
    }

    public async Task UpdateAsync(Kit kit)
    {
        _context.Set<Kit>().Update(kit);
        await _context.SaveChangesAsync();
    }
}
