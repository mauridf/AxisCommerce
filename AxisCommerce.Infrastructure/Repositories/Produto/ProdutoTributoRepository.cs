using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoTributoRepository : IProdutoTributoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoTributoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoTributo produtoTributo)
    {
        _context.Set<ProdutoTributo>().Add(produtoTributo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoTributo = await GetByIdAsync(id);
        if(produtoTributo != null)
        {
            _context.Set<ProdutoTributo>().Remove(produtoTributo);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoTributo>> GetAllAsync()
    {
        return await _context.Set<ProdutoTributo>().ToListAsync();
    }

    public async Task<ProdutoTributo?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoTributo>().FindAsync(id);
    }

    public async Task UpdateAsync(ProdutoTributo produtoTributo)
    {
        _context.Set<ProdutoTributo>().Update(produtoTributo);
        await _context.SaveChangesAsync();
    }
}
