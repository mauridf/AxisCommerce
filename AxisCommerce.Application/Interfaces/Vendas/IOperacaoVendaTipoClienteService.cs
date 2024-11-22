using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface IOperacaoVendaTipoClienteService
{
    Task AddAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente);
    Task<OperacaoVendaTipoCliente?> GetByIdAsync(Guid id);
    Task<IEnumerable<OperacaoVendaTipoCliente>> GetAllAsync();
    Task UpdateAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente);
    Task DeleteAsync(Guid id);
}
