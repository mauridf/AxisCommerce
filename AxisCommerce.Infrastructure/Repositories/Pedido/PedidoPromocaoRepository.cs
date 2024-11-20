using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class PedidoPromocaoRepository : IPedidoPromocaoRepository
{
    private readonly ApplicationDbContext _context;

    public PedidoPromocaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PedidoPromocao pedidoPromocao)
    {
        _context.Set<PedidoPromocao>().Add(pedidoPromocao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var pedidoPromocao = await GetByIdAsync(id);
        if(pedidoPromocao != null)
        {
            _context.Set<PedidoPromocao>().Remove(pedidoPromocao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PedidoPromocao>> GetAllAsync()
    {
        return await _context.Set<PedidoPromocao>().ToListAsync();
    }

    public async Task<PedidoPromocao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PedidoPromocao>().FindAsync(id);
    }

    public async Task UpdateAsync(PedidoPromocao pedidoPromocao)
    {
        _context.Set<PedidoPromocao>().Update(pedidoPromocao);
        await _context.SaveChangesAsync();
    }
}
