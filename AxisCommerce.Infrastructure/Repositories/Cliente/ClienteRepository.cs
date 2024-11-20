using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Clientes;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Cliente cliente)
    {
        await _context.Set<Cliente>().AddAsync(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var cliente = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (cliente != null)
        {
            _context.Set<Cliente>().Remove(cliente);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Cliente>> GetAllAsync()
    {
        return await _context.Set<Cliente>().ToListAsync();
    }

    public async Task<Domain.Entities.Clientes.Cliente?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Cliente>().FindAsync(id);
    }

    public async Task UpdateAsync(Domain.Entities.Clientes.Cliente cliente)
    {
        _context.Set<Cliente>().Update(cliente);
        await _context.SaveChangesAsync();
    }
}
