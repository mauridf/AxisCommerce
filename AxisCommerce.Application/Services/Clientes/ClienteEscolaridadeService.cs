using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;

namespace AxisCommerce.Application.Services.Clientes;

public class ClienteEscolaridadeService : IClienteEscolaridadeService
{
    private readonly IClienteEscolaridadeRepository _clienteEscolaridadeRepository;

    public ClienteEscolaridadeService(IClienteEscolaridadeRepository clienteEscolaridadeRepository)
    {
        _clienteEscolaridadeRepository = clienteEscolaridadeRepository;
    }

    public async Task AddClienteEscolaridadeAsync(ClienteEscolaridade clienteEscolaridade)
    {
        await _clienteEscolaridadeRepository.AddAsync(clienteEscolaridade);
    }

    public async Task DeleteClienteEscolaridadeAsync(Guid id)
    {
        await _clienteEscolaridadeRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ClienteEscolaridade>> GetAllClienteEscolaridadeAsync()
    {
        return await _clienteEscolaridadeRepository.GetAllAsync();
    }

    public async Task<ClienteEscolaridade?> GetClienteEscolaridadeByIdAsync(Guid id)
    {
        return await _clienteEscolaridadeRepository.GetByIdAsync(id);
    }

    public async Task UpdateClienteEscolaridadeAsync(ClienteEscolaridade clienteEscolaridade)
    {
        await _clienteEscolaridadeRepository.UpdateAsync(clienteEscolaridade);
    }
}
