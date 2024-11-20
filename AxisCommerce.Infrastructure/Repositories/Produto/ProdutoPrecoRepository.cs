using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoPrecoRepository : IProdutoPrecoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoPrecoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoPreco produtoPreco)
    {
        _context.Set<ProdutoPreco>().Add(produtoPreco);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoPreco = await GetByIdAsync(id);
        if(produtoPreco != null)
        {
            _context.Set<ProdutoPreco>().Remove(produtoPreco);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoPreco>> GetAllAsync()
    {
        return await _context.Set<ProdutoPreco>().ToListAsync();
    }

    public async Task<ProdutoPreco?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoPreco>().FindAsync(id);
    }

    public async Task UpdateAsync(ProdutoPreco produtoPreco)
    {
        _context.Set<ProdutoPreco>().Update(produtoPreco);
        await _context.SaveChangesAsync();
    }
}
