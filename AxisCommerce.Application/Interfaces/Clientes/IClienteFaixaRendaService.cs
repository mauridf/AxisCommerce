using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Application.Interfaces.Clientes;

public interface IClienteFaixaRendaService
{
    Task<IEnumerable<ClienteFaixaRenda>> GetAllClienteFaixaAsync();
    Task<ClienteFaixaRenda?> GetClienteFaixaByIdAsync(Guid id);
    Task AddClienteFaixaAsync(ClienteFaixaRenda clienteFaixaRenda);
    Task UpdateClienteFaixaAsync(ClienteFaixaRenda clienteFaixaRenda);
    Task DeleteClienteFaixaAsync(Guid id);
}
