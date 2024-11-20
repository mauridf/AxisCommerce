using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Application.Interfaces.Caixa;

public interface ICaixaRecebimentoService
{
    Task<IEnumerable<CaixaRecebimento>> GetAllCaixaRecebimentoAsync();
    Task<CaixaRecebimento?> GetCaixaRecebimentoByIdAsync(Guid id);
    Task AddCaixaRecebimentoAsync(CaixaRecebimento caixaRecebimento);
    Task UpdateCaixaRecebimentoAsync(CaixaRecebimento caixaRecebimento);
    Task DeleteCaixaRecebimentoAsync(Guid id);
}
