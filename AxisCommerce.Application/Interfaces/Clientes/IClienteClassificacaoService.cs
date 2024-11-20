using AxisCommerce.Domain.Entities.Clientes;

namespace AxisCommerce.Application.Interfaces.Clientes
{
    public interface IClienteClassificacaoService
    {
        Task<IEnumerable<ClienteClassificacao>> GetAllClienteClassificacaosAsync();
        Task<ClienteClassificacao?> GetClienteClassificacaoByIdAsync(Guid id);
        Task AddClienteClassificacaoAsync(ClienteClassificacao clienteClassificacao);
        Task UpdateClienteClassificacaoAsync(ClienteClassificacao clienteClassificacao);
        Task DeleteClienteClassificacaoAsync(Guid id);
    }
}
