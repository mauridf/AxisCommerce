using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoAtributoRepository : IProdutoAtributoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoAtributoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoAtributo produtoAtributo)
    {
        _context.Set<ProdutoAtributo>().Add(produtoAtributo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoAtributo = await GetByIdAsync(id);
        if (produtoAtributo != null)
        {
            _context.Set<ProdutoAtributo>().Remove(produtoAtributo);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoAtributo>> GetAllAsync()
    {
        return await _context.Set<ProdutoAtributo>().ToListAsync();
    }

    public async Task UpdateAsync(ProdutoAtributo produtoAtributo)
    {
        _context.Set<ProdutoAtributo>().Update(produtoAtributo);
        await _context.SaveChangesAsync();
    }

    public async Task<ProdutoAtributo?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoAtributo>().FindAsync(id);
    }
}
