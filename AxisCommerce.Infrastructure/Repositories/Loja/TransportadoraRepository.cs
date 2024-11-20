using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Loja;

public class TransportadoraRepository : ITransportadoraRepository
{
    private readonly ApplicationDbContext _context;

    public TransportadoraRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Transportadora transportadora)
    {
        await _context.Set<Transportadora>().AddAsync(transportadora);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var transportadora = await GetByIdAsync(id);
        if (transportadora != null)
        {
            _context.Set<Transportadora>().Remove(transportadora);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Transportadora>> GetAllAsync()
    {
        return await _context.Set<Transportadora>().ToListAsync();
    }

    public async Task<Transportadora?> GetByCNPJ(string cnpj)
    {
        return await _context.Set<Transportadora>().FindAsync(cnpj);
    }

    public async Task<Transportadora?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Transportadora>().FindAsync(id);
    }

    public async Task UpdateAsync(Transportadora transportadora)
    {
        _context.Set<Transportadora>().Update(transportadora);
        await _context.SaveChangesAsync();
    }
}
