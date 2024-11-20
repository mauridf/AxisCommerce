using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Caixa;

public class CaixaRecebimentoPgtoRepository : ICaixaRecebimentoPgtoRepository
{
    private readonly ApplicationDbContext _context;

    public CaixaRecebimentoPgtoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CaixaRecebimentoPgto caixaRecebimentoPgto)
    {
        await _context.Set<CaixaRecebimentoPgto>().AddAsync(caixaRecebimentoPgto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var caixaRecebimentoPgto = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (caixaRecebimentoPgto != null)
        {
            _context.Set<CaixaRecebimentoPgto>().Remove(caixaRecebimentoPgto);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CaixaRecebimentoPgto>> GetAllAsync()
    {
        return await _context.Set<CaixaRecebimentoPgto>().ToListAsync();
    }

    public async Task<CaixaRecebimentoPgto?> GetByIdAsync(Guid id)
    {
        return await _context.Set<CaixaRecebimentoPgto>().FindAsync(id);
    }

    public async Task UpdateAsync(CaixaRecebimentoPgto caixaRecebimentoPgto)
    {
        _context.Set<CaixaRecebimentoPgto>().Update(caixaRecebimentoPgto);
        await _context.SaveChangesAsync();
    }
}
