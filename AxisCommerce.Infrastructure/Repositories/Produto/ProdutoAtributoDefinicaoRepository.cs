using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos
{
    public class ProdutoAtributoDefinicaoRepository : IProdutoAtributoDefinicaoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoAtributoDefinicaoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao)
        {
            _context.Set<ProdutoAtributoDefinicao>().Add(produtoAtributoDefinicao);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var produtoAtributoDefinicao = await GetByIdAsync(id);
            if(produtoAtributoDefinicao != null)
            {
                _context.Set<ProdutoAtributoDefinicao>().Remove(produtoAtributoDefinicao);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ProdutoAtributoDefinicao>> GetAllAsync()
        {
            return await _context.Set<ProdutoAtributoDefinicao>().ToListAsync();
        }

        public async Task<ProdutoAtributoDefinicao?> GetByIdAsync(Guid id)
        {
            return await _context.Set<ProdutoAtributoDefinicao>().FindAsync(id);
        }

        public async Task UpdateAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao)
        {
            _context.Set<ProdutoAtributoDefinicao>().Update(produtoAtributoDefinicao);
            await _context.SaveChangesAsync();
        }
    }
}
