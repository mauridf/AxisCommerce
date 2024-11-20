using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;

namespace AxisCommerce.Application.Services.Clientes;

public class ClienteSubTipoService : IClienteSubTipoService
{
    private readonly IClienteSubTipoRepository _clienteSubTipoRepository;

    public ClienteSubTipoService(IClienteSubTipoRepository clienteSubTipoRepository)
    {
        _clienteSubTipoRepository = clienteSubTipoRepository;
    }

    public async Task AddClienteSubTipoAsync(ClienteSubTipo clienteSubTipo)
    {
        await _clienteSubTipoRepository.AddAsync(clienteSubTipo);
    }

    public async Task DeleteClienteSubTipoAsync(Guid id)
    {
        await _clienteSubTipoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ClienteSubTipo>> GetAllClienteSubTipoAsync()
    {
        return await _clienteSubTipoRepository.GetAllAsync();
    }

    public async Task<ClienteSubTipo?> GetClienteSubTipoByIdAsync(Guid id)
    {
        return await _clienteSubTipoRepository.GetByIdAsync(id);
    }

    public async Task UpdateClienteSubTipoAsync(ClienteSubTipo clienteSubTipo)
    {
        await _clienteSubTipoRepository.UpdateAsync(clienteSubTipo);
    }
}
