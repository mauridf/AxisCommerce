using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pedidos;

public class MotivoDevolucaoRepository : IMotivoDevolucaoRepository
{
    private readonly ApplicationDbContext _context;

    public MotivoDevolucaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(MotivoDevolucao motivoDevolucao)
    {
        _context.Set<MotivoDevolucao>().Add(motivoDevolucao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var motivoDevolucao = await GetByIdAsync(id);
        if(motivoDevolucao != null)
        {
            _context.Set<MotivoDevolucao>().Remove(motivoDevolucao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<MotivoDevolucao>> GetAllAsync()
    {
        return await _context.Set<MotivoDevolucao>().ToListAsync();
    }

    public async Task<MotivoDevolucao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<MotivoDevolucao>().FindAsync(id);
    }

    public async Task UpdateAsync(MotivoDevolucao motivoDevolucao)
    {
        _context.Set<MotivoDevolucao>().Update(motivoDevolucao);
        await _context.SaveChangesAsync();
    }
}
