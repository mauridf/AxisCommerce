using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoRepository : IProdutoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Produto produto)
    {
        _context.Set<Produtos>().Add(produto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produto = await GetByIdAsync(id);
        if(produto != null)
        {
            _context.Set<Produtos>().Remove(produto);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _context.Set<Produtos>().ToListAsync();
    }

    public async Task<Produto?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Produtos>().FindAsync(id);
    }

    public async Task UpdateAsync(Produto produto)
    {
        _context.Set<Produtos>().Update(produto);
        await _context.SaveChangesAsync();
    }
}
