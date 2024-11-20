using AxisCommerce.Domain.Entities.Caixa;

namespace AxisCommerce.Domain.Interfaces.Caixa;

public interface ICaixaControleRepository
{
    Task<(bool, string)> VerificarStatusCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId);
    Task<(bool, string)> AbrirCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId);
    Task<(bool, string)> FecharCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId);
}
