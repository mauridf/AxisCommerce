using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface IOperacaoVendaService
{
    Task AddAsync(OperacaoVenda operacaoVenda);
    Task<OperacaoVenda?> GetByIdAsync(Guid id);
    Task<IEnumerable<OperacaoVenda>> GetAllAsync();
    Task UpdateAsync(OperacaoVenda operacaoVenda);
    Task DeleteAsync(Guid id);
}
