using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Loja;

public class LojaControleRepository : ILojaControleRepository
{
    private readonly ApplicationDbContext _context;

    public LojaControleRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(LojaControle lojaControle)
    {
        await _context.Set<LojaControle>().AddAsync(lojaControle);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var lojaControle = await GetByIdAsync(id);
        if(lojaControle != null)
        {
            _context.Set<LojaControle>().Remove(lojaControle);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<LojaControle>> GetAllAsync()
    {
        return await _context.Set<LojaControle>().ToListAsync();
    }

    public async Task<LojaControle?> GetByIdAsync(Guid id)
    {
        return await _context.Set<LojaControle>().FindAsync(id);
    }

    public async Task UpdateAsync(LojaControle lojaControle)
    {
        _context.Set<LojaControle>().Update(lojaControle);
        await _context.SaveChangesAsync();
    }
}
