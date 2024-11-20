using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Produtos;

public class UnidadeMedidaRepository : IUnidadeMedidaRepository
{
    private readonly ApplicationDbContext _context;

    public UnidadeMedidaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(UnidadeMedida unidadeMedida)
    {
        _context.Set<UnidadeMedida>().Add(unidadeMedida);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var unidadeMedida = await GetByIdAsync(id);
        if(unidadeMedida != null)
        {
            _context.Set<UnidadeMedida>().Remove(unidadeMedida);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<UnidadeMedida>> GetAllAsync()
    {
        return await _context.Set<UnidadeMedida>().ToListAsync();
    }

    public async Task<UnidadeMedida?> GetByIdAsync(Guid id)
    {
        return await _context.Set<UnidadeMedida>().FindAsync(id);
    }

    public async Task<UnidadeMedida?> GetBySimbolo(string simbolo)
    {
        return await _context.Set<UnidadeMedida>().FindAsync(simbolo);
    }

    public async Task UpdateAsync(UnidadeMedida unidadeMedida)
    {
        _context.Set<UnidadeMedida>().Update(unidadeMedida);
        await _context.SaveChangesAsync();
    }
}
