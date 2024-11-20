using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;

namespace AxisCommerce.Application.Services.Lojas;

public class TransportadoraService : ITransportadoraService
{
    private readonly ITransportadoraRepository _transportadoraRepository;

    public TransportadoraService(ITransportadoraRepository transportadoraRepository)
    {
        _transportadoraRepository = transportadoraRepository;
    }

    public async Task AddAsync(Transportadora transportadora)
    {
        await _transportadoraRepository.AddAsync(transportadora);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _transportadoraRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Transportadora>> GetAllAsync()
    {
        return await _transportadoraRepository.GetAllAsync();
    }

    public async Task<Transportadora?> GetByCNPJ(string cnpj)
    {
        return await _transportadoraRepository.GetByCNPJ(cnpj);
    }

    public async Task<Transportadora?> GetByIdAsync(Guid id)
    {
        return await _transportadoraRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Transportadora transportadora)
    {
        await _transportadoraRepository.UpdateAsync(transportadora);
    }
}
