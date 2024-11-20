using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoCorBasicaRepository : IProdutoCorBasicaRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoCorBasicaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoCorBasica produtoCorBasica)
    {
        _context.Set<ProdutoCorBasica>().Add(produtoCorBasica);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoCorBasica = await GetByIdAsync(id);
        if (produtoCorBasica != null)
        {
            _context.Set<ProdutoCorBasica>().Remove(produtoCorBasica);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoCorBasica>> GetAllAsync()
    {
        return await _context.Set<ProdutoCorBasica>().ToListAsync();
    }

    public async Task<ProdutoCorBasica?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoCorBasica?>().FindAsync(id);
    }

    public async Task UpdateAsync(ProdutoCorBasica produtoCorBasica)
    {
        _context.Set<ProdutoCorBasica>().Update(produtoCorBasica);
        await _context.SaveChangesAsync();
    }
}
