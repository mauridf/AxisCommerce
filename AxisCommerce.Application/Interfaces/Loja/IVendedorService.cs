using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Application.Interfaces.Loja;

public interface IVendedorService
{
    Task AddAsync(Vendedor vendedor);
    Task<Vendedor?> GetByIdAsync(Guid id);
    Task<Vendedor?> GetByCodVendedor(string codigoVendedor);
    Task<IEnumerable<Vendedor>> GetAllAsync();
    Task UpdateAsync(Vendedor vendedor);
    Task DeleteAsync(Guid id);
    Task<IEnumerable<Vendedor>> GetGerentesAsync();
    Task<IEnumerable<Vendedor>> GetOperadoresAsync();
}
