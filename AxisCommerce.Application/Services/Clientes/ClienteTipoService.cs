using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;

namespace AxisCommerce.Application.Services.Clientes;

public class ClienteTipoService : IClienteTipoService
{
    private readonly IClienteTipoRepository _clienteTipoRepository;

    public ClienteTipoService(IClienteTipoRepository clienteTipoRepository)
    {
        _clienteTipoRepository = clienteTipoRepository;
    }

    public async Task AddClienteTipoAsync(ClienteTipo clienteTipo)
    {
        await _clienteTipoRepository.AddAsync(clienteTipo);
    }

    public async Task DeleteClienteTipoAsync(Guid id)
    {
        await _clienteTipoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ClienteTipo>> GetAllClienteTipoAsync()
    {
        return await _clienteTipoRepository.GetAllAsync();
    }

    public async Task<ClienteTipo?> GetClienteTipoByIdAsync(Guid id)
    {
        return await _clienteTipoRepository.GetByIdAsync(id);
    }

    public async Task UpdateClienteTipoAsync(ClienteTipo clienteTipo)
    {
        await _clienteTipoRepository.UpdateAsync(clienteTipo);
    }
}
