using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface IOperacaoVendaCondicaoPgtoService
{
    Task AddAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto);
    Task<OperacaoVendaCondicaoPgto?> GetByIdAsync(Guid id);
    Task<IEnumerable<OperacaoVendaCondicaoPgto>> GetAllAsync();
    Task UpdateAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto);
    Task DeleteAsync(Guid id);
}
