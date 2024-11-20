using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Loja;

public class FornecedorRepository : IFornecedorRepository
{
    private readonly ApplicationDbContext _context;

    public FornecedorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Fornecedor fornecedor)
    {
        await _context.Set<Fornecedor>().AddAsync(fornecedor);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var fornecedor = await GetByIdAsync(id);
        if (fornecedor != null)
        {
            _context.Set<Fornecedor>().Remove(fornecedor);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Fornecedor>> GetAllAsync()
    {
        return await _context.Set<Fornecedor>().ToListAsync();
    }

    public async Task<Fornecedor?> GetByCNPJ(string cnpj)
    {
        return await _context.Set<Fornecedor>().FindAsync(cnpj);
    }

    public async Task<Fornecedor?> GetByIdAsync(Guid id)
    {
        return await _context.Set<Fornecedor>().FindAsync(id);
    }

    public async Task UpdateAsync(Fornecedor fornecedor)
    {
        _context.Set<Fornecedor>().Update(fornecedor);
        await _context.SaveChangesAsync();
    }
}
