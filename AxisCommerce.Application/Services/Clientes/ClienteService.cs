using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;

namespace AxisCommerce.Application.Services.Clientes;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
    {
        return await _clienteRepository.GetAllAsync();
    }

    public async Task<Cliente?> GetClienteByIdAsync(Guid id)
    {
        return await _clienteRepository.GetByIdAsync(id);
    }

    public async Task AddClienteAsync(Cliente cliente)
    {
        await _clienteRepository.AddAsync(cliente);
    }

    public async Task UpdateClienteAsync(Cliente cliente)
    {
        await _clienteRepository.UpdateAsync(cliente);
    }

    public async Task DeleteClienteAsync(Guid id)
    {
        await _clienteRepository.DeleteAsync(id);
    }
}
