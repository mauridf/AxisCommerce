using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Caixa;

public class CaixaControleRepository : ICaixaControleRepository
{
    private readonly ApplicationDbContext _context;

    public CaixaControleRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<(bool, string)> VerificarStatusCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        var caixaControle = await _context.Set<CaixaControle>()
            .Where(c => c.GerenteId == gerenteId && c.OperadorCaixaId == operadorId && c.TerminalId == terminalId)
            .OrderByDescending(c => c.DataHoraAbertura)
            .FirstOrDefaultAsync();

        if (caixaControle != null && caixaControle.DataHoraFechamento == null)
        {
            return (true, "O Caixa está aberto.");
        }

        return (false, "O Caixa está fechado.");
    }

    public async Task<(bool, string)> AbrirCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        var (caixaAberto, mensagem) = await VerificarStatusCaixaAsync(gerenteId, operadorId, terminalId);

        if (caixaAberto)
        {
            return (false, "O Caixa já se encontra Aberto, é necessário fechar para que se possa abrir.");
        }

        var novoCaixaControle = new CaixaControle
        {
            Id = Guid.NewGuid(),
            GerenteId = gerenteId,
            OperadorCaixaId = operadorId,
            TerminalId = terminalId,
            DataHoraAbertura = DateTime.UtcNow,
            DataHoraFechamento = null
        };

        await _context.Set<CaixaControle>().AddAsync(novoCaixaControle);
        await _context.SaveChangesAsync();

        return (true, "Caixa Aberto com Sucesso.");
    }

    public async Task<(bool, string)> FecharCaixaAsync(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        var (caixaAberto, mensagem) = await VerificarStatusCaixaAsync(gerenteId, operadorId, terminalId);

        if (!caixaAberto)
        {
            return (false, "O Caixa já se encontra Fechado, se desejar já pode efetuar a Abertura.");
        }

        var caixaControle = await _context.Set<CaixaControle>()
            .Where(c => c.GerenteId == gerenteId && c.OperadorCaixaId == operadorId && c.TerminalId == terminalId && c.DataHoraFechamento == null)
            .FirstOrDefaultAsync();

        if (caixaControle != null)
        {
            caixaControle.DataHoraFechamento = DateTime.UtcNow;
            _context.Set<CaixaControle>().Update(caixaControle);
            await _context.SaveChangesAsync();

            return (true, "Caixa Fechado com Sucesso.");
        }

        return (false, "Erro ao tentar fechar o caixa.");
    }
}
