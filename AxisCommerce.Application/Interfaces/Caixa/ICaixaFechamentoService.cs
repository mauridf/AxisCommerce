using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Application.Interfaces.Caixa;

public interface ICaixaFechamentoService
{
    Task<IEnumerable<CaixaFechamento>> GetAllCaixaFechamentoAsync();
    Task<CaixaFechamento?> GetCaixaFechamentoByIdAsync(Guid id);
    Task AddCaixaFechamentoAsync(CaixaFechamento caixaFechamento);
    Task UpdateCaixaFechamentoAsync(CaixaFechamento caixaFechamento);
    Task DeleteCaixaFechamentoAsync(Guid id);
}
