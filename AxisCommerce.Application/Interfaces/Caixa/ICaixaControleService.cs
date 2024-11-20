using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Application.Interfaces.Caixa;

public interface ICaixaControleService
{
    Task<(bool, string)> VerificarStatusCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId);
    Task<(bool, string)> AbrirCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId);
    Task<(bool, string)> FecharCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId);
}
