using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class PedidoRepository : IPedidoRepository
{
    private readonly ApplicationDbContext _context;

    public PedidoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Pedido pedido)
    {
        _context.Set<Pedido>().Add(pedido);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pedido = await GetByIdAsync(id);
        if(pedido != null)
        {
            _context.Set<Pedido>().Remove(pedido);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Pedido>> GetAllAsync()
    {
        return await _context.Set<Pedido>().ToListAsync();
    }

    public async Task<Pedido?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Pedido>().FindAsync(id);
    }

    public async Task UpdateAsync(Pedido pedido)
    {
        _context.Set<Pedido>().Update(pedido);
        await _context.SaveChangesAsync();
    }
}
