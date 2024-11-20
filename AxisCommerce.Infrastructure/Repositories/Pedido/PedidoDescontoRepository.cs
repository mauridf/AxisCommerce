using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class PedidoDescontoRepository : IPedidoDescontoRepository
{
    private readonly ApplicationDbContext _context;

    public PedidoDescontoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PedidoDesconto pedidoDesconto)
    {
        _context.Set<PedidoDesconto>().Add(pedidoDesconto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pedidoDesconto = await GetByIdAsync(id);
        if(pedidoDesconto != null)
        {
            _context.Set<PedidoDesconto>().Remove(pedidoDesconto);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PedidoDesconto>> GetAllAsync()
    {
        return await _context.Set<PedidoDesconto>().ToListAsync();
    }

    public async Task<PedidoDesconto?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PedidoDesconto>().FindAsync(id);
    }

    public async Task UpdateAsync(PedidoDesconto pedidoDesconto)
    {
        _context.Set<PedidoDesconto>().Update(pedidoDesconto);
        await _context.SaveChangesAsync();
    }
}
