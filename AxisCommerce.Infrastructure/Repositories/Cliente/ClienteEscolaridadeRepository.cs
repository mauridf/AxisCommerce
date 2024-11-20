using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Clientes;

public class ClienteEscolaridadeRepository : IClienteEscolaridadeRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteEscolaridadeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ClienteEscolaridade clienteEscolaridade)
    {
        await _context.Set<ClienteEscolaridade>().AddAsync(clienteEscolaridade);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var clienteEscolaridade = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (clienteEscolaridade != null)
        {
            _context.Set<ClienteEscolaridade>().Remove(clienteEscolaridade);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ClienteEscolaridade>> GetAllAsync()
    {
        return await _context.Set<ClienteEscolaridade>().ToListAsync();
    }

    public async Task<ClienteEscolaridade?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ClienteEscolaridade>().FindAsync(id);
    }

    public async Task UpdateAsync(ClienteEscolaridade clienteEscolaridade)
    {
        _context.Set<ClienteEscolaridade>().Update(clienteEscolaridade);
        await _context.SaveChangesAsync();
    }
}
