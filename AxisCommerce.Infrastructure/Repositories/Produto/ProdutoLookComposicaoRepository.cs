using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class ProdutoLookComposicaoRepository : IProdutoLookComposicaoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoLookComposicaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ProdutoLookComposicao produtoLookComposicao)
    {
        _context.Set<ProdutoLookComposicao>().Add(produtoLookComposicao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var produtoLookComposicao = await GetByIdAsync(id);
        if(produtoLookComposicao != null)
        {
            _context.Set<ProdutoLookComposicao>().Remove(produtoLookComposicao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProdutoLookComposicao>> GetAllAsync()
    {
        return await _context.Set<ProdutoLookComposicao>().ToListAsync();
    }

    public async Task<ProdutoLookComposicao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ProdutoLookComposicao>().FindAsync(id);
    }

    public async Task UpdateAsync(ProdutoLookComposicao produtoLookComposicao)
    {
        _context.Set<ProdutoLookComposicao>().Update(produtoLookComposicao);
        await _context.SaveChangesAsync();
    }
}
