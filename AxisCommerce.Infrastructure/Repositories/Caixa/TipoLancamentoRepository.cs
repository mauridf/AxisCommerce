using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Caixa;

public class TipoLancamentoRepository : ITipoLancamentoRepository
{
    private readonly ApplicationDbContext _context;

    public TipoLancamentoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TipoLancamento tipoLancamento)
    {
        await _context.Set<TipoLancamento>().AddAsync(tipoLancamento);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var tipoLancamento = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (tipoLancamento != null)
        {
            _context.Set<TipoLancamento>().Remove(tipoLancamento);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<TipoLancamento>> GetAllAsync()
    {
        return await _context.Set<TipoLancamento>().ToListAsync();
    }

    public async Task<TipoLancamento?> GetByIdAsync(Guid id)
    {
        return await _context.Set<TipoLancamento>().FindAsync(id);
    }

    public async Task UpdateAsync(TipoLancamento tipoLancamento)
    {
        _context.Set<TipoLancamento>().Update(tipoLancamento);
        await _context.SaveChangesAsync();
    }
}
