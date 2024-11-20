using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class EstoqueRepository : IEstoqueRepository
{
    private readonly ApplicationDbContext _context;

    public EstoqueRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Estoque estoque)
    {
        _context.Set<Estoque>().Add(estoque);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var estoque = await GetByIdAsync(id);
        if(estoque != null)
        {
            _context.Set<Estoque>().Remove(estoque);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Estoque>> GetAllAsync()
    {
        return await _context.Set<Estoque>().ToListAsync();
    }

    public async Task<Estoque?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Estoque>().FindAsync(id);
    }

    public async Task UpdateAsync(Estoque estoque)
    {
        _context.Set<Estoque>().Update(estoque);
        await _context.SaveChangesAsync();
    }
}
