using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Clientes;

public class ClienteFaixaRendaRepository : IClienteFaixaRendaRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteFaixaRendaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ClienteFaixaRenda clienteFaixaRenda)
    {
        await _context.Set<ClienteFaixaRenda>().AddAsync(clienteFaixaRenda);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var clienteFaixaRenda = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (clienteFaixaRenda != null)
        {
            _context.Set<ClienteFaixaRenda>().Remove(clienteFaixaRenda);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ClienteFaixaRenda>> GetAllAsync()
    {
        return await _context.Set<ClienteFaixaRenda>().ToListAsync();
    }

    public async Task<ClienteFaixaRenda?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ClienteFaixaRenda>().FindAsync(id);
    }

    public async Task UpdateAsync(ClienteFaixaRenda clienteFaixaRenda)
    {
        _context.Set<ClienteFaixaRenda>().Update(clienteFaixaRenda);
        await _context.SaveChangesAsync();
    }
}
