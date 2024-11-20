using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Domain.Interfaces.Caixa;

public interface ICaixaRecebimentoRepository
{
    Task AddAsync(CaixaRecebimento caixaRecebimento);
    Task<CaixaRecebimento?> GetByIdAsync(Guid id);
    Task<IEnumerable<CaixaRecebimento>> GetAllAsync();
    Task UpdateAsync(CaixaRecebimento caixaRecebimento);
    Task DeleteAsync(Guid id);
}
