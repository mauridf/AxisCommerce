using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class PromocaoRepository : IPromocaoRepository
{
    private readonly ApplicationDbContext _context;

    public PromocaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Promocao promocao)
    {
        _context.Set<Promocao>().Add(promocao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var promocao = await GetByIdAsync(id);
        if(promocao != null)
        {
            _context.Set<Promocao>().Remove(promocao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Promocao>> GetAllAsync()
    {
        return await _context.Set<Promocao>().ToListAsync();
    }

    public async Task<Promocao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Promocao>().FindAsync(id);
    }

    public async Task UpdateAsync(Promocao promocao)
    {
        _context.Set<Promocao>().Update(promocao);
        await _context.SaveChangesAsync();
    }
}
