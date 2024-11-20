using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Clientes;

public class ClienteClassificacaoRepository : IClienteClassificacaoRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteClassificacaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(ClienteClassificacao clienteClassificacao)
    {
        await _context.Set<ClienteClassificacao>().AddAsync(clienteClassificacao);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var clienteClassificacao = await GetByIdAsync(id); // Certifique-se que GetByIdAsync é também assíncrono
        if (clienteClassificacao != null)
        {
            _context.Set<ClienteClassificacao>().Remove(clienteClassificacao);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ClienteClassificacao>> GetAllAsync()
    {
        return await _context.Set<ClienteClassificacao>().ToListAsync();
    }

    public async Task<ClienteClassificacao?> GetByIdAsync(Guid id)
    {
        return await _context.Set<ClienteClassificacao>().FindAsync(id);
    }

    public async Task UpdateAsync(ClienteClassificacao clienteClassificacao)
    {
        _context.Set<ClienteClassificacao>().Update(clienteClassificacao);
        await _context.SaveChangesAsync();
    }
}
