using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pagamento;

public class CondicaoPagtoRepository : ICondicaoPagtoRepository
{
    private readonly ApplicationDbContext _context;

    public CondicaoPagtoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CondicaoPagto condicaoPagto)
    {
        await _context.Set<CondicaoPagto>().AddAsync(condicaoPagto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var condicaoPagto = await GetByIdAsync(id);
        if(condicaoPagto != null)
        {
            _context.Set<CondicaoPagto>().Remove(condicaoPagto);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CondicaoPagto>> GetAllAsync()
    {
        return await _context.Set<CondicaoPagto>().ToListAsync();
    }

    public async Task<CondicaoPagto?> GetByIdAsync(Guid id)
    {
        return await _context.Set<CondicaoPagto>().FindAsync(id);
    }

    public async Task UpdateAsync(CondicaoPagto condicaoPagto)
    {
        _context.Set<CondicaoPagto>().Update(condicaoPagto);
        await _context.SaveChangesAsync();
    }
}
