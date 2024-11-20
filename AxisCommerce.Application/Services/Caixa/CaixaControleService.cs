using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;

namespace AxisCommerce.Application.Services.Caixa;

public class CaixaControleService : ICaixaControleService
{
    private readonly ICaixaControleRepository _caixaControleRepository;

    public CaixaControleService(ICaixaControleRepository caixaControleRepository)
    {
        _caixaControleRepository = caixaControleRepository;
    }

    public async Task<(bool, string)> VerificarStatusCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        return await _caixaControleRepository.VerificarStatusCaixaAsync(gerenteId, operadorId, terminalId);
    }

    public async Task<(bool, string)> AbrirCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        return await _caixaControleRepository.AbrirCaixaAsync(gerenteId, operadorId, terminalId);
    }

    public async Task<(bool, string)> FecharCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        return await _caixaControleRepository.FecharCaixaAsync(gerenteId, operadorId, terminalId);
    }
}
