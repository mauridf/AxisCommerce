using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pagamento;

public class CredenciadoraCartaoRepository : ICredenciadoraCartaoRepository
{
    private readonly ApplicationDbContext _context;

    public CredenciadoraCartaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CredenciadoraCartao credenciadoraCartao)
    {
        await _context.Set<CredenciadoraCartao>().AddAsync(credenciadoraCartao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var credenciadoraCartao = await GetByIdAsync(id);
        if(credenciadoraCartao != null)
        {
            _context.Set<CredenciadoraCartao>().Remove(credenciadoraCartao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<CredenciadoraCartao>> GetAllAsync()
    {
        return await _context.Set<CredenciadoraCartao>().ToListAsync();
    }

    public async Task<CredenciadoraCartao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<CredenciadoraCartao>().FindAsync(id);
    }

    public async Task UpdateAsync(CredenciadoraCartao credenciadoraCartao)
    {
        _context.Set<CredenciadoraCartao>().Update(credenciadoraCartao);
        await _context.SaveChangesAsync();
    }
}
