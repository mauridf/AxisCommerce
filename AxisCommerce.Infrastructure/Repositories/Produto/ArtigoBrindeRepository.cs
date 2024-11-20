using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ArtigoBrindeRepository : IArtigoBrindeRepository
{
    private readonly ApplicationDbContext _context;

    public ArtigoBrindeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ArtigoBrinde artigoBrinde)
    {
        _context.Set<ArtigoBrinde>().Add(artigoBrinde);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var artigoBrinde = await GetByIdAsync(id);
        if(artigoBrinde != null)
        {
            _context.Set<ArtigoBrinde>().Remove(artigoBrinde);
            _context.SaveChanges();
        }
    }

    public async Task<IEnumerable<ArtigoBrinde>> GetAllAsync()
    {
        return await _context.Set<ArtigoBrinde>().ToListAsync();
    }

    public async Task<ArtigoBrinde?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ArtigoBrinde>().FindAsync(id);
    }

    public async Task UpdateAsync(ArtigoBrinde artigoBrinde)
    {
        _context.Set<ArtigoBrinde>().Update(artigoBrinde);
        await _context.SaveChangesAsync();
    }
}
