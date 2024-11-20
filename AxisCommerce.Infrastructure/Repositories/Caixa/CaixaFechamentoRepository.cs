using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Caixa;

public class CaixaFechamentoRepository : ICaixaFechamentoRepository
{
    private readonly ApplicationDbContext _context;

    public CaixaFechamentoRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(CaixaFechamento caixaFechamento)
    {
        await _context.Set<CaixaFechamento>().AddAsync(caixaFechamento);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var caixaFechamento = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (caixaFechamento != null)
        {
            _context.Set<CaixaFechamento>().Remove(caixaFechamento);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CaixaFechamento>> GetAllAsync()
    {
        return await _context.Set<CaixaFechamento>().ToListAsync();
    }

    public async Task<CaixaFechamento?> GetByIdAsync(Guid id)
    {
        return await _context.Set<CaixaFechamento>().FindAsync(id);
    }

    public async Task UpdateAsync(CaixaFechamento caixaFechamento)
    {
        _context.Set<CaixaFechamento>().Update(caixaFechamento);
        await _context.SaveChangesAsync();
    }
}
