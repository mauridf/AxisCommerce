using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface IOperacaoVendaRepository
{
    Task AddAsync(OperacaoVenda operacaoVenda);
    Task<OperacaoVenda?> GetByIdAsync(Guid id);
    Task<IEnumerable<OperacaoVenda>> GetAllAsync();
    Task UpdateAsync(OperacaoVenda operacaoVenda);
    Task DeleteAsync(Guid id);
}
