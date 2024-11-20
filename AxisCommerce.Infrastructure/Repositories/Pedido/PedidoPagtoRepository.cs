using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class PedidoPagtoRepository : IPedidoPagtoRepository
{
    private readonly ApplicationDbContext _context;

    public PedidoPagtoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PedidoPagto pedidoPgto)
    {
        _context.Set<PedidoPagto>().Add(pedidoPgto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pedidoPgto = await GetByIdAsync(id);
        if(pedidoPgto != null)
        {
            _context.Set<PedidoPagto>().Remove(pedidoPgto);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PedidoPagto>> GetAllAsync()
    {
        return await _context.Set<PedidoPagto>().ToListAsync();
    }

    public async Task<PedidoPagto?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PedidoPagto>().FindAsync(id);
    }

    public async Task UpdateAsync(PedidoPagto pedidoPgto)
    {
        _context.Set<PedidoPagto>().Update(pedidoPgto);
        await _context.SaveChangesAsync();
    }
}
