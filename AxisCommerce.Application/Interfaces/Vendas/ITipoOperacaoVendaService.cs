using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface ITipoOperacaoVendaService
{
    Task AddAsync(TipoOperacaoVenda tipoOperacaoVenda);
    Task<TipoOperacaoVenda?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoOperacaoVenda>> GetAllAsync();
    Task UpdateAsync(TipoOperacaoVenda tipoOperacaoVenda);
    Task DeleteAsync(Guid id);
}
