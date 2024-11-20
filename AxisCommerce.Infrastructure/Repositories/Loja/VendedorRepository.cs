using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Loja;

public class VendedorRepository : IVendedorRepository
{
    private readonly ApplicationDbContext _context;

    public VendedorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Vendedor vendedor)
    {
        await _context.Set<Vendedor>().AddAsync(vendedor);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var vendedor = await GetByIdAsync(id);
        if(vendedor != null)
        {
            _context.Set<Vendedor>().Remove(vendedor);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Vendedor>> GetAllAsync()
    {
        return await _context.Set<Vendedor>().ToListAsync();
    }

    public async Task<Vendedor?> GetByCodVendedor(string codigoVendedor)
    {
        return await _context.Set<Vendedor>().FindAsync(codigoVendedor);
    }

    public async Task<Vendedor?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Vendedor>().FindAsync(id);
    }

    public async Task UpdateAsync(Vendedor vendedor)
    {
        _context.Set<Vendedor>().Update(vendedor);
        await _context.SaveChangesAsync();
    }

    // Novo método para obter gerentes
    public async Task<IEnumerable<Vendedor>> GetGerentesAsync()
    {
        return await _context.Set<Vendedor>()
                             .Where(v => v.IndicaGerente)
                             .ToListAsync();
    }

    // Novo método para obter operadores
    public async Task<IEnumerable<Vendedor>> GetOperadoresAsync()
    {
        return await _context.Set<Vendedor>()
                             .Where(v => v.IndicaOperadorCaixa)
                             .ToListAsync();
    }
}
