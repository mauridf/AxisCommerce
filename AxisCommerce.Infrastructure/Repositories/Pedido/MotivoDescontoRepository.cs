using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class MotivoDescontoRepository : IMotivoDescontoRepository
{
    private readonly ApplicationDbContext _context;

    public MotivoDescontoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(MotivoDesconto motivoDesconto)
    {
        _context.Set<MotivoDesconto>().Add(motivoDesconto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var motivoDesconto = await GetByIdAsync(id);
        if(motivoDesconto != null)
        {
            _context.Set<MotivoDesconto>().Remove(motivoDesconto);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<MotivoDesconto>> GetAllAsync()
    {
        return await _context.Set<MotivoDesconto>().ToListAsync();
    }

    public async Task<MotivoDesconto?> GetByIdAsync(Guid id)
    {
        return await _context.Set<MotivoDesconto>().FindAsync(id);
    }

    public async Task UpdateAsync(MotivoDesconto motivoDesconto)
    {
        _context.Set<MotivoDesconto>().Update(motivoDesconto);
        await _context.SaveChangesAsync();
    }
}
