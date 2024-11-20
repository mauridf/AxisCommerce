using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class OperacaoVendaTipoClienteRepository : IOperacaoVendaTipoClienteRepository
{
    private readonly ApplicationDbContext _context;

    public OperacaoVendaTipoClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente)
    {
        _context.Set<OperacaoVendaTipoCliente>().Add(operacaoVendaTipoCliente);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var operacaoVendaTipoCliente = await GetByIdAsync(id);
        if(operacaoVendaTipoCliente != null)
        {
            _context.Set<OperacaoVendaTipoCliente>().Remove(operacaoVendaTipoCliente);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<OperacaoVendaTipoCliente>> GetAllAsync()
    {
        return await _context.Set<OperacaoVendaTipoCliente>().ToListAsync();
    }

    public async Task<OperacaoVendaTipoCliente?> GetByIdAsync(Guid id)
    {
        return await _context.Set<OperacaoVendaTipoCliente>().FindAsync(id);
    }

    public async Task UpdateAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente)
    {
        _context.Set<OperacaoVendaTipoCliente>().Update(operacaoVendaTipoCliente);
        await _context.SaveChangesAsync();
    }
}
