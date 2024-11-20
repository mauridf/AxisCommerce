using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoCodigoBarraRepository : IProdutoCodigoBarraRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoCodigoBarraRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoCodigoBarra produtoCodigoBarra)
    {
        _context.Set<ProdutoCodigoBarra>().AddAsync(produtoCodigoBarra);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoCodigoBarra = await GetByIdAsync(id);
        if(produtoCodigoBarra != null)
        {
            _context.Set<ProdutoCodigoBarra>().Remove(produtoCodigoBarra);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoCodigoBarra>> GetAllAsync()
    {
        return await _context.Set<ProdutoCodigoBarra>().ToListAsync();
    }

    public async Task<ProdutoCodigoBarra?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoCodigoBarra>().FindAsync(id);
    }

    public async Task UpdateAsync(ProdutoCodigoBarra produtoCodigoBarra)
    {
        _context.Set<ProdutoCodigoBarra>().Update(produtoCodigoBarra);
        await _context.SaveChangesAsync();
    }
}
