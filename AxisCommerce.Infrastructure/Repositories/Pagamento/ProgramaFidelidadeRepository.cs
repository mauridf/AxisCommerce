using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pagamento;

public class ProgramaFidelidadeRepository : IProgramaFidelidadeRepository
{
    private readonly ApplicationDbContext _context;

    public ProgramaFidelidadeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProgramaFidelidade programaFidelidade)
    {
        await _context.Set<ProgramaFidelidade>().AddAsync(programaFidelidade);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var programaFidelidade = await GetByIdAsync(id);
        if(programaFidelidade != null)
        {
            _context.Set<ProgramaFidelidade>().Remove(programaFidelidade);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProgramaFidelidade>> GetAllAsync()
    {
        return await _context.Set<ProgramaFidelidade>().ToListAsync();
    }

    public async Task<ProgramaFidelidade?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProgramaFidelidade>().FindAsync(id);
    }

    public async Task UpdateAsync(ProgramaFidelidade programaFidelidade)
    {
        _context.Set<ProgramaFidelidade>().Update(programaFidelidade);
        await _context.SaveChangesAsync();
    }
}
