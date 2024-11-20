using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class PedidoEntregaRepository : IPedidoEntregaRepository
{
    private readonly ApplicationDbContext _context;

    public PedidoEntregaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PedidoEntrega pedidoEntrega)
    {
        _context.Set<PedidoEntrega>().Add(pedidoEntrega);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pedidoEntrega = await GetByIdAsync(id);
        if (pedidoEntrega != null)
        {
            _context.Set<PedidoEntrega>().Remove(pedidoEntrega);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PedidoEntrega>> GetAllAsync()
    {
        return await _context.Set<PedidoEntrega>().ToListAsync();
    }

    public async Task<PedidoEntrega?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PedidoEntrega>().FindAsync(id);
    }

    public async Task UpdateAsync(PedidoEntrega pedidoEntrega)
    {
        _context.Set<PedidoEntrega>().Update(pedidoEntrega);
        await _context.SaveChangesAsync();
    }
}
