using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Venda;

public class OperacaoVendaCondicaoPgtoRepository : IOperacaoVendaCondicaoPgtoRepository
{
    private readonly ApplicationDbContext _context;

    public OperacaoVendaCondicaoPgtoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto)
    {
        _context.Set<OperacaoVendaCondicaoPgto>().Add(operacaoVendaCondicaoPgto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var operacaoVendaCondicaoPgto = await GetByIdAsync(id);
        if(operacaoVendaCondicaoPgto !=  null)
        {
            _context.Set<OperacaoVendaCondicaoPgto>().Remove(operacaoVendaCondicaoPgto);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<OperacaoVendaCondicaoPgto>> GetAllAsync()
    {
        return await _context.Set<OperacaoVendaCondicaoPgto>().ToListAsync();
    }

    public async Task<OperacaoVendaCondicaoPgto?> GetByIdAsync(Guid id)
    {
        return await _context.Set<OperacaoVendaCondicaoPgto>().FindAsync(id);
    }

    public async Task UpdateAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto)
    {
        _context.Set<OperacaoVendaCondicaoPgto>().Update(operacaoVendaCondicaoPgto);
        await _context.SaveChangesAsync();
    }
}
