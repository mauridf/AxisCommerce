using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Caixa;

public class CaixaLancamentoRepository : ICaixaLancamentoRepository
{
    private readonly ApplicationDbContext _context;

    public CaixaLancamentoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CaixaLancamento caixaLancamento)
    {
        await _context.Set<CaixaLancamento>().AddAsync(caixaLancamento);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var caixaLancamento = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (caixaLancamento != null)
        {
            _context.Set<CaixaLancamento>().Remove(caixaLancamento);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CaixaLancamento>> GetAllAsync()
    {
        return await _context.Set<CaixaLancamento>().ToListAsync();
    }

    public async Task<CaixaLancamento?> GetByIdAsync(Guid id)
    {
        return await _context.Set<CaixaLancamento>().FindAsync(id);
    }

    public async Task UpdateAsync(CaixaLancamento caixaLancamento)
    {
        _context.Set<CaixaLancamento>().Update(caixaLancamento);
        await _context.SaveChangesAsync();
    }
}
