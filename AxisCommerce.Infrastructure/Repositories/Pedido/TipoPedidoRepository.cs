using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class TipoPedidoRepository : ITipoPedidoRepository
{
    private readonly ApplicationDbContext _context;

    public TipoPedidoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TipoPedido tipoPedido)
    {
        _context.Set<TipoPedido>().Add(tipoPedido);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var tipoPedido = await GetByIdAsync(id);
        if(tipoPedido != null)
        {
            _context.Set<TipoPedido>().Remove(tipoPedido);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<TipoPedido>> GetAllAsync()
    {
        return await _context.Set<TipoPedido>().ToListAsync();
    }

    public async Task<TipoPedido?> GetByIdAsync(Guid id)
    {
        return await _context.Set<TipoPedido>().FindAsync(id);
    }

    public async Task UpdateAsync(TipoPedido tipoPedido)
    {
        _context.Set<TipoPedido>().Update(tipoPedido);
        await _context.SaveChangesAsync();
    }
}
