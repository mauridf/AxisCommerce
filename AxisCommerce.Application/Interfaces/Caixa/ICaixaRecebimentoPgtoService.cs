using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Application.Interfaces.Caixa;

public interface ICaixaRecebimentoPgtoService
{
    Task<IEnumerable<CaixaRecebimentoPgto>> GetAllCaixaRecebimentoPgtoAsync();
    Task<CaixaRecebimentoPgto?> GetCaixaRecebimentoPgtoByIdAsync(Guid id);
    Task AddCaixaRecebimentoPgtoAsync(CaixaRecebimentoPgto caixaRecebimentoPgto);
    Task UpdateCaixaRecebimentoPgtoAsync(CaixaRecebimentoPgto caixaRecebimentoPgto);
    Task DeleteCaixaRecebimentoPgtoAsync(Guid id);
}
