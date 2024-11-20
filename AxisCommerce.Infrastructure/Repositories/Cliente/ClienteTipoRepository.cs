using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Clientes;

public class ClienteTipoRepository : IClienteTipoRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteTipoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ClienteTipo clienteTipo)
    {
        await _context.Set<ClienteTipo>().AddAsync(clienteTipo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var clienteTipo = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (clienteTipo != null)
        {
            _context.Set<ClienteTipo>().Remove(clienteTipo);
            await _context.SaveChangesAsync();
        };
    }

    public async Task<IEnumerable<ClienteTipo>> GetAllAsync()
    {
        return await _context.Set<ClienteTipo>().ToListAsync();
    }

    public async Task<ClienteTipo?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ClienteTipo>().FindAsync(id);
    }

    public async Task UpdateAsync(ClienteTipo clienteTipo)
    {
        _context.Set<ClienteTipo>().Update(clienteTipo);
        await _context.SaveChangesAsync();
    }
}
