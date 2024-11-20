using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class TipoOperacaoVendaRepository : ITipoOperacaoVendaRepository
{
    private readonly ApplicationDbContext _context;

    public TipoOperacaoVendaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TipoOperacaoVenda tipoOperacaoVenda)
    {
        _context.Set<TipoOperacaoVenda>().Add(tipoOperacaoVenda);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var tipoOperacaoVenda = await GetByIdAsync(id);
        if(tipoOperacaoVenda != null)
        {
            _context.Set<TipoOperacaoVenda>().Remove(tipoOperacaoVenda);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<TipoOperacaoVenda>> GetAllAsync()
    {
        return await _context.Set<TipoOperacaoVenda>().ToListAsync();
    }

    public async Task<TipoOperacaoVenda?> GetByIdAsync(Guid id)
    {
        return await _context.Set<TipoOperacaoVenda>().FindAsync(id);
    }

    public async Task UpdateAsync(TipoOperacaoVenda tipoOperacaoVenda)
    {
        _context.Set<TipoOperacaoVenda>().Update(tipoOperacaoVenda);
        await _context.SaveChangesAsync();
    }
}
