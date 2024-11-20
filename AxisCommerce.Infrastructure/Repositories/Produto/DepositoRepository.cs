using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class DepositoRepository : IDepositoRepository
{
    private readonly ApplicationDbContext _context;

    public DepositoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Deposito deposito)
    {
        _context.Set<Deposito>().Add(deposito);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var deposito = await GetByIdAsync(id);
        if(deposito !=  null)
        {
            _context.Set<Deposito>().Remove(deposito);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Deposito>> GetAllAsync()
    {
        return await _context.Set<Deposito>().ToListAsync();
    }

    public async Task<Deposito?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Deposito>().FindAsync(id);
    }

    public async Task UpdateAsync(Deposito deposito)
    {
        _context.Set<Deposito>().Update(deposito);
        await _context.SaveChangesAsync();
    }
}
