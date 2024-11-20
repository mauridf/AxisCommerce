using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class PedidoItemRepository : IPedidoItemRepository
{
    private readonly ApplicationDbContext _context;

    public PedidoItemRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PedidoItem peditoItem)
    {
        _context.Set<PedidoItem>().Add(peditoItem);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pedidoItem = await GetByIdAsync(id);
        if(pedidoItem != null)
        {
            _context.Set<PedidoItem>().Remove(pedidoItem);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PedidoItem>> GetAllAsync()
    {
        return await _context.Set<PedidoItem>().ToListAsync();
    }

    public async Task<PedidoItem?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PedidoItem>().FindAsync(id);
    }

    public async Task UpdateAsync(PedidoItem pedidoItem)
    {
        _context.Set<PedidoItem>().Update(pedidoItem);
        await _context.SaveChangesAsync();
    }
}
