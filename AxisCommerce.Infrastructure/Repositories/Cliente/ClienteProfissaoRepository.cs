using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Clientes;

public class ClienteProfissaoRepository : IClienteProfissaoRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteProfissaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ClienteProfissao clienteProfissao)
    {
        await _context.Set<ClienteProfissao>().AddAsync(clienteProfissao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var clienteProfissao = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (clienteProfissao != null)
        {
            _context.Set<ClienteProfissao>().Remove(clienteProfissao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ClienteProfissao>> GetAllAsync()
    {
        return await _context.Set<ClienteProfissao>().ToListAsync();
    }

    public async Task<ClienteProfissao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ClienteProfissao>().FindAsync(id);
    }

    public async Task UpdateAsync(ClienteProfissao clienteProfissao)
    {
        _context.Set<ClienteProfissao>().Update(clienteProfissao);
        await _context.SaveChangesAsync();
    }
}
