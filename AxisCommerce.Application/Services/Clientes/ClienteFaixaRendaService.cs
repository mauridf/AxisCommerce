using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Interfaces.Clientes;

namespace AxisCommerce.Application.Services.Clientes;

public class ClienteFaixaRendaService : IClienteFaixaRendaService
{
    private readonly IClienteFaixaRendaRepository _clienteFaixaRendaRepository;

    public ClienteFaixaRendaService(IClienteFaixaRendaRepository clienteFaixaRendaRepository)
    {
        _clienteFaixaRendaRepository = clienteFaixaRendaRepository;
    }

    public async Task AddClienteFaixaAsync(ClienteFaixaRenda clienteFaixaRenda)
    {
        await _clienteFaixaRendaRepository.AddAsync(clienteFaixaRenda);
    }

    public async Task DeleteClienteFaixaAsync(Guid id)
    {
        await _clienteFaixaRendaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ClienteFaixaRenda>> GetAllClienteFaixaAsync()
    {
        return await _clienteFaixaRendaRepository.GetAllAsync();
    }

    public async Task<ClienteFaixaRenda?> GetClienteFaixaByIdAsync(Guid id)
    {
        return await _clienteFaixaRendaRepository.GetByIdAsync(id);
    }

    public async Task UpdateClienteFaixaAsync(ClienteFaixaRenda clienteFaixaRenda)
    {
        await _clienteFaixaRendaRepository.UpdateAsync(clienteFaixaRenda);
    }
}
