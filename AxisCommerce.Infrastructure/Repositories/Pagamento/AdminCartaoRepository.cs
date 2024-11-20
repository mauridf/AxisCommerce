using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pagamento;

public class AdminCartaoRepository : IAdminCartaoRepository
{
    private readonly ApplicationDbContext _context;

    public AdminCartaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(AdminCartao adminCartao)
    {
        await _context.Set<AdminCartao>().AddAsync(adminCartao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var adminCartao = await GetByIdAsync(id);
        if(adminCartao != null)
        {
            _context.Set<AdminCartao>().Remove(adminCartao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<AdminCartao>> GetAllAsync()
    {
        return await _context.Set<AdminCartao>().ToListAsync();
    }

    public async Task<AdminCartao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<AdminCartao>().FindAsync(id);
    }

    public async Task UpdateAsync(AdminCartao adminCartao)
    {
        _context.Set<AdminCartao>().Update(adminCartao);
        await _context.SaveChangesAsync();
    }
}
