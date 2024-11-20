using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class PromocaoTipoOfertaRepository : IPromocaoTipoOfertaRepository
{
    private readonly ApplicationDbContext _context;

    public PromocaoTipoOfertaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PromocaoTipoOferta promocaoTipoOferta)
    {
        _context.Set<PromocaoTipoOferta>().Add(promocaoTipoOferta);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var promocaoTipoOferta = await GetByIdAsync(id);
        if(promocaoTipoOferta != null)
        {
            _context.Set<PromocaoTipoOferta>().Remove(promocaoTipoOferta);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PromocaoTipoOferta>> GetAllAsync()
    {
        return await _context.Set<PromocaoTipoOferta>().ToListAsync();
    }

    public async Task<PromocaoTipoOferta?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PromocaoTipoOferta>().FindAsync(id);
    }

    public async Task UpdateAsync(PromocaoTipoOferta promocaoTipoOferta)
    {
        _context.Set<PromocaoTipoOferta>().Update(promocaoTipoOferta);
        await _context.SaveChangesAsync();
    }
}
