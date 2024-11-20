using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class TipoOfertaRepository : ITipoOfertaRepository
{
    private readonly ApplicationDbContext _context;

    public TipoOfertaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TipoOferta tipoOferta)
    {
        _context.Set<TipoOferta>().Add(tipoOferta);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var tipoOferta = await GetByIdAsync(id);
        if(tipoOferta != null)
        {
            _context.Set<TipoOferta>().Remove(tipoOferta);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<TipoOferta>> GetAllAsync()
    {
        return await _context.Set<TipoOferta>().ToListAsync();
    }

    public async Task<TipoOferta?> GetByIdAsync(Guid id)
    {
        return await _context.Set<TipoOferta>().FindAsync(id);
    }

    public async Task UpdateAsync(TipoOferta tipoOferta)
    {
        _context.Set<TipoOferta>().Update(tipoOferta);
        await _context.SaveChangesAsync();
    }
}
