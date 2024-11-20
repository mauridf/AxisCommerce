using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Caixa;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Caixa;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Caixa)]
[Route("api/v{version:apiVersion}/[controller]")]
public class CaixaControleController : ControllerBase
{
    private readonly ICaixaControleService _caixaControleService;

    public CaixaControleController(ICaixaControleService caixaControleService)
    {
        _caixaControleService = caixaControleService;
    }

    [HttpGet("verificar-status")]
    public async Task<IActionResult> VerificarStatusCaixa(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        try
        {
            var (status, mensagem) = await _caixaControleService.VerificarStatusCaixaAsync(gerenteId, operadorId, terminalId);
            return Ok(new { Status = status, Mensagem = mensagem });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter status do caixa.", error = ex.Message });
        }
    }

    [HttpPost("abrir-caixa")]
    public async Task<IActionResult> AbrirCaixa(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        try
        {
            var (sucesso, mensagem) = await _caixaControleService.AbrirCaixaAsync(gerenteId, operadorId, terminalId);
            if (sucesso)
            {
                return Ok(new { Mensagem = mensagem });
            }
            return BadRequest(new { Mensagem = mensagem });
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para abertura de caixa.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao abrir caixa.", error = ex.Message });
        }
    }

    [HttpPost("fechar-caixa")]
    public async Task<IActionResult> FecharCaixa(Guid gerenteId, Guid operadorId, Guid terminalId)
    {
        try
        {
            var (sucesso, mensagem) = await _caixaControleService.FecharCaixaAsync(gerenteId, operadorId, terminalId);
            if (sucesso)
            {
                return Ok(new { Mensagem = mensagem });
            }
            return BadRequest(new { Mensagem = mensagem });
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para fechamento de caixa.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao fechar caixa.", error = ex.Message });
        }
    }
}
