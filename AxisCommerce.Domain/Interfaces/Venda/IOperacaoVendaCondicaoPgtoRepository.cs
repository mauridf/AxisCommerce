using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface IOperacaoVendaCondicaoPgtoRepository
{
    Task AddAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto);
    Task<OperacaoVendaCondicaoPgto?> GetByIdAsync(Guid id);
    Task<IEnumerable<OperacaoVendaCondicaoPgto>> GetAllAsync();
    Task UpdateAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto);
    Task DeleteAsync(Guid id);
}
