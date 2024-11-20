using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Caixa;

public class CaixaRecebimentoRepository : ICaixaRecebimentoRepository
{
    private readonly ApplicationDbContext _context;

    public CaixaRecebimentoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CaixaRecebimento caixaRecebimento)
    {
        await _context.Set<CaixaRecebimento>().AddAsync(caixaRecebimento);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var caixaRecebimento = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (caixaRecebimento != null)
        {
            _context.Set<CaixaRecebimento>().Remove(caixaRecebimento);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CaixaRecebimento>> GetAllAsync()
    {
        return await _context.Set<CaixaRecebimento>().ToListAsync();
    }

    public async Task<CaixaRecebimento?> GetByIdAsync(Guid id)
    {
        return await _context.Set<CaixaRecebimento>().FindAsync(id);
    }

    public async Task UpdateAsync(CaixaRecebimento caixaRecebimento)
    {
        _context.Set<CaixaRecebimento>().Update(caixaRecebimento);
        await _context.SaveChangesAsync();
    }
}
