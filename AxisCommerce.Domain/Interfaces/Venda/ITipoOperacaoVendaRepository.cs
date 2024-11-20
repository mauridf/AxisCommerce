using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface ITipoOperacaoVendaRepository
{
    Task AddAsync(TipoOperacaoVenda tipoOperacaoVenda);
    Task<TipoOperacaoVenda?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoOperacaoVenda>> GetAllAsync();
    Task UpdateAsync(TipoOperacaoVenda tipoOperacaoVenda);
    Task DeleteAsync(Guid id);
}
