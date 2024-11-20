using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Pagamento;

public class MoedaIndicadorRepository : IMoedaIndicadorRepository
{
    private readonly ApplicationDbContext _context;

    public MoedaIndicadorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(MoedaIndicador moedaIndicador)
    {
        await _context.Set<MoedaIndicador>().AddAsync(moedaIndicador);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var moedaIndicador = await GetByIdAsync(id);
        if(moedaIndicador == null)
        {
            _context.Set<MoedaIndicador>().Remove(moedaIndicador);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<MoedaIndicador>> GetAllAsync()
    {
        return await _context.Set<MoedaIndicador>().ToListAsync();
    }

    public async Task<MoedaIndicador?> GetByIdAsync(Guid id)
    {
        return await _context.Set<MoedaIndicador>().FindAsync(id);
    }

    public async Task UpdateAsync(MoedaIndicador moedaIndicador)
    {
        _context.Set<MoedaIndicador>().Update(moedaIndicador);
        await _context.SaveChangesAsync();
    }
}
