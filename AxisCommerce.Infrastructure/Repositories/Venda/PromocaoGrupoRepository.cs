using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class PromocaoGrupoRepository : IPromocaoGrupoRepository
{
    private readonly ApplicationDbContext _context;

    public PromocaoGrupoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(PromocaoGrupo promocaoGrupo)
    {
        _context.Set<PromocaoGrupo>().Add(promocaoGrupo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var promocaoGrupo = await GetByIdAsync(id);
        if(promocaoGrupo != null)
        {
            _context.Set<PromocaoGrupo>().Remove(promocaoGrupo);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<PromocaoGrupo>> GetAllAsync()
    {
        return await _context.Set<PromocaoGrupo>().ToListAsync();
    }

    public async Task<PromocaoGrupo?> GetByIdAsync(Guid id)
    {
        return await _context.Set<PromocaoGrupo>().FindAsync(id);
    }

    public async Task UpdateAsync(PromocaoGrupo promocaoGrupo)
    {
        _context.Set<PromocaoGrupo>().Update(promocaoGrupo);
        await _context.SaveChangesAsync();
    }
}
