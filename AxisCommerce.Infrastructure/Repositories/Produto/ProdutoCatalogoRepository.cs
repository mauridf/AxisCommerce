using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoCatalogoRepository : IProdutoCatalogoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoCatalogoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoCatalogo produtoCatalogo)
    {
        _context.Set<ProdutoCatalogo>().Add(produtoCatalogo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoCatalogo = await GetByIdAsync(id);
        if(produtoCatalogo != null)
        {
            _context.Set<ProdutoCatalogo>().Remove(produtoCatalogo);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoCatalogo>> GetAllAsync()
    {
        return await _context.Set<ProdutoCatalogo>().ToListAsync();
    }

    public async Task<ProdutoCatalogo?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoCatalogo>().FindAsync(id);
    }

    public async Task UpdateAsync(ProdutoCatalogo produtoCatalogo)
    {
        _context.Set<ProdutoCatalogo>().Update(produtoCatalogo);
        await _context.SaveChangesAsync();
    }
}
