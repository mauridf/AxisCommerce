using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Loja;

public class LojaHorarioRepository : ILojaHorarioRepository
{
    private readonly ApplicationDbContext _context;

    public LojaHorarioRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(LojaHorario lojaHorario)
    {
        await _context.Set<LojaHorario>().AddAsync(lojaHorario);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var lojaHorario = await GetByIdAsync(id);
        if(lojaHorario == null)
        {
            _context.Set<LojaHorario>().Remove(lojaHorario);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<LojaHorario>> GetAllAsync()
    {
        return await _context.Set<LojaHorario>().ToListAsync();
    }

    public async Task<LojaHorario?> GetByIdAsync(Guid id)
    {
        return await _context.Set<LojaHorario>().FindAsync(id);
    }

    public async Task UpdateAsync(LojaHorario lojaHorario)
    {
        _context.Set<LojaHorario>().Update(lojaHorario);
        await _context.SaveChangesAsync();
    }
}
