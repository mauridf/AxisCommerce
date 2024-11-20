using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;

namespace AxisCommerce.Application.Services.Clientes;

public class ClienteProfissaoService : IClienteProfissaoService
{
    private readonly IClienteProfissaoRepository _clienteProfissaoRepository;

    public ClienteProfissaoService(IClienteProfissaoRepository clienteProfissaoRepository)
    {
        _clienteProfissaoRepository = clienteProfissaoRepository;
    }

    public async Task AddClienteProfissaoAsync(ClienteProfissao clienteProfissao)
    {
        await _clienteProfissaoRepository.AddAsync(clienteProfissao);
    }

    public async Task DeleteClienteProfissaoAsync(Guid id)
    {
        await _clienteProfissaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ClienteProfissao>> GetAllClienteProfissaoAsync()
    {
        return await _clienteProfissaoRepository.GetAllAsync();
    }

    public async Task<ClienteProfissao?> GetClienteProfissaoByIdAsync(Guid id)
    {
        return await _clienteProfissaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateClienteProfissaoAsync(ClienteProfissao clienteProfissao)
    {
        await _clienteProfissaoRepository.UpdateAsync(clienteProfissao);
    }
}
