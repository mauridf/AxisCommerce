using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoKitRepository : IProdutoKitRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoKitRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoKit produtoKit)
    {
        _context.Set<ProdutoKit>().Add(produtoKit);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoKit = await GetByIdAsync(id);
        if(produtoKit != null)
        {
            _context.Set<ProdutoKit>().Remove(produtoKit);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoKit>> GetAllAsync()
    {
        return await _context.Set<ProdutoKit>().ToListAsync();
    }

    public async Task<ProdutoKit?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoKit>().FindAsync(id);
    }

    public async Task UpdateAsync(ProdutoKit produtoKit)
    {
        _context.Set<ProdutoKit>().Update(produtoKit);
        await _context.SaveChangesAsync();
    }
}
