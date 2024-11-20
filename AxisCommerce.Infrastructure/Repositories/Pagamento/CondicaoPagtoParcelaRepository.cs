using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pagamento;

public class CondicaoPagtoParcelaRepository : ICondicaoPagtoParcelaRepository
{
    private readonly ApplicationDbContext _context;

    public CondicaoPagtoParcelaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CondicaoPagtoParcela condicaoPagtoParcela)
    {
        await _context.Set<CondicaoPagtoParcela>().AddAsync(condicaoPagtoParcela);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var condicaoPagtoParcela = await GetByIdAsync(id);
        if(condicaoPagtoParcela != null) 
        {
            _context.Set<CondicaoPagtoParcela>().Remove(condicaoPagtoParcela);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CondicaoPagtoParcela>> GetAllAsync()
    {
        return await _context.Set<CondicaoPagtoParcela>().ToListAsync();
    }

    public async Task<CondicaoPagtoParcela?> GetByIdAsync(Guid id)
    {
        return await _context.Set<CondicaoPagtoParcela>().FindAsync(id);
    }

    public async Task UpdateAsync(CondicaoPagtoParcela condicaoPagtoParcela)
    {
        _context.Set<CondicaoPagtoParcela>().Update(condicaoPagtoParcela);
        await _context.SaveChangesAsync();
    }
}
