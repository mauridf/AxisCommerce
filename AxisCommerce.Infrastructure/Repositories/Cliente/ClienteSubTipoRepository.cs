using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Clientes;

public class ClienteSubTipoRepository : IClienteSubTipoRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteSubTipoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ClienteSubTipo clienteSubTipo)
    {
        await _context.Set<ClienteSubTipo>().AddAsync(clienteSubTipo);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var clienteSubTipo = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (clienteSubTipo != null)
        {
            _context.Set<ClienteSubTipo>().Remove(clienteSubTipo);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ClienteSubTipo>> GetAllAsync()
    {
        return await _context.Set<ClienteSubTipo>().ToListAsync();
    }

    public async Task<ClienteSubTipo?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ClienteSubTipo>().FindAsync(id);
    }

    public async Task UpdateAsync(ClienteSubTipo clienteSubTipo)
    {
        _context.Set<ClienteSubTipo>().Update(clienteSubTipo);
        await _context.SaveChangesAsync();
    }
}
