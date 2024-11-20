using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class OperacaoVendaRepository : IOperacaoVendaRepository
{
    private readonly ApplicationDbContext _context;

    public OperacaoVendaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(OperacaoVenda operacaoVenda)
    {
        _context.Set<OperacaoVenda>().Add(operacaoVenda);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var operacaoVenda = await GetByIdAsync(id);
        if(operacaoVenda != null)
        {
            _context.Set<OperacaoVenda>().Remove(operacaoVenda);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<OperacaoVenda>> GetAllAsync()
    {
        return await _context.Set<OperacaoVenda>().ToListAsync();
    }

    public async Task<OperacaoVenda?> GetByIdAsync(Guid id)
    {
        return await _context.Set<OperacaoVenda>().FindAsync(id);
    }

    public async Task UpdateAsync(OperacaoVenda operacaoVenda)
    {
        _context.Set<OperacaoVenda>().Update(operacaoVenda);
        await _context.SaveChangesAsync();
    }
}
