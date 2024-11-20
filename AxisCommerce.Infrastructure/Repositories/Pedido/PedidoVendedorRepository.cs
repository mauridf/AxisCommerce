using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class PedidoVendedorRepository : IPedidoVendedorRepository
{
    private readonly ApplicationDbContext _context;

    public PedidoVendedorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PedidoVendedor pedidoVendedor)
    {
        _context.Set<PedidoVendedor>().Add(pedidoVendedor);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pedidoVendedor = await GetByIdAsync(id);
        if(pedidoVendedor != null)
        {
            _context.Set<PedidoVendedor>().Remove(pedidoVendedor);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PedidoVendedor>> GetAllAsync()
    {
        return await _context.Set<PedidoVendedor>().ToListAsync();
    }

    public async Task<PedidoVendedor?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PedidoVendedor?>().FindAsync(id);
    }

    public async Task UpdateAsync(PedidoVendedor pedidoVendedor)
    {
        _context.Set<PedidoVendedor>().Update(pedidoVendedor);
        await _context.SaveChangesAsync();
    }
}
