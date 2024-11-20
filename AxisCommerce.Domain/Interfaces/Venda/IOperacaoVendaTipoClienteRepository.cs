using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface IOperacaoVendaTipoClienteRepository
{
    Task AddAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente);
    Task<OperacaoVendaTipoCliente?> GetByIdAsync(Guid id);
    Task<IEnumerable<OperacaoVendaTipoCliente>> GetAllAsync();
    Task UpdateAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente);
    Task DeleteAsync(Guid id);
}
