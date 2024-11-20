using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pagamento;

public class TipoPagamentoRepository : ITipoPagamentoRepository
{
    private readonly ApplicationDbContext _context;

    public TipoPagamentoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TipoPagamento tipoPagamento)
    {
        await _context.Set<TipoPagamento>().AddAsync(tipoPagamento);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var tipoPagamento = await GetByIdAsync(id);
        if(tipoPagamento != null)
        {
            _context.Set<TipoPagamento>().Remove(tipoPagamento);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<TipoPagamento>> GetAllAsync()
    {
        return await _context.Set<TipoPagamento>().ToListAsync();
    }

    public async Task<TipoPagamento?> GetByIdAsync(Guid id)
    {
        return await _context.Set<TipoPagamento>().FindAsync(id);
    }

    public async Task UpdateAsync(TipoPagamento tipoPagamento)
    {
        _context.Set<TipoPagamento>().Update(tipoPagamento);
        await _context.SaveChangesAsync();
    }
}
