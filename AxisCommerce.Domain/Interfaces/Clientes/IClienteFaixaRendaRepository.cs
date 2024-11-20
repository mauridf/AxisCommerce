using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Domain.Interfaces.Clientes;

public interface IClienteFaixaRendaRepository
{
    Task AddAsync(ClienteFaixaRenda clienteFaixaRenda);
    Task<ClienteFaixaRenda?> GetByIdAsync(Guid id);
    Task<IEnumerable<ClienteFaixaRenda>> GetAllAsync();
    Task UpdateAsync(ClienteFaixaRenda clienteFaixaRenda);
    Task DeleteAsync(Guid id);
}
