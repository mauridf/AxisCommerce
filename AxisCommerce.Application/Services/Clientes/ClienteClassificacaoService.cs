using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;

namespace AxisCommerce.Application.Services.Clientes;

public class ClienteClassificacaoService : IClienteClassificacaoService
{
    private readonly IClienteClassificacaoRepository _clienteClassificacaoRepository;

    public ClienteClassificacaoService(IClienteClassificacaoRepository clienteClassificacaoRepository)
    {
        _clienteClassificacaoRepository = clienteClassificacaoRepository;
    }

    public async Task AddClienteClassificacaoAsync(ClienteClassificacao clienteClassificacao)
    {
        await _clienteClassificacaoRepository.AddAsync(clienteClassificacao);
    }

    public async Task DeleteClienteClassificacaoAsync(Guid id)
    {
        await _clienteClassificacaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ClienteClassificacao>> GetAllClienteClassificacaosAsync()
    {
        return await _clienteClassificacaoRepository.GetAllAsync();
    }

    public async Task<ClienteClassificacao?> GetClienteClassificacaoByIdAsync(Guid id)
    {
        return await _clienteClassificacaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateClienteClassificacaoAsync(ClienteClassificacao clienteClassificacao)
    {
        await _clienteClassificacaoRepository.UpdateAsync(clienteClassificacao);
    }
}
