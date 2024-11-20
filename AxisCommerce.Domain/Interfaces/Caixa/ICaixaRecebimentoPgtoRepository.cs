using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Domain.Interfaces.Caixa;

public interface ICaixaRecebimentoPgtoRepository
{
    Task AddAsync(CaixaRecebimentoPgto caixaRecebimentoPgto);
    Task<CaixaRecebimentoPgto?> GetByIdAsync(Guid id);
    Task<IEnumerable<CaixaRecebimentoPgto>> GetAllAsync();
    Task UpdateAsync(CaixaRecebimentoPgto caixaRecebimentoPgto);
    Task DeleteAsync(Guid id);
}
