using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Caixa;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Caixa)]
[Route("api/v{version:apiVersion}/[controller]")]
public class CaixaFechamentoController : ControllerBase
{
    private readonly ICaixaFechamentoService _caixaFechamentoService;

    public CaixaFechamentoController(ICaixaFechamentoService caixaFechamentoService)
    {
        _caixaFechamentoService = caixaFechamentoService;
    }

    [HttpGet("buscar-fechamentos-caixa")]
    public async Task<IActionResult> GetAllFechamentos()
    {
        try
        {
            var fechamentos = await _caixaFechamentoService.GetAllCaixaFechamentoAsync();
            return Ok(fechamentos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os fechamentos de caixa.", error = ex.Message });
        }
    }

    [HttpGet("buscar-fechamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetFechamentoById(Guid id)
    {
        try
        {
            var cliente = await _caixaFechamentoService.GetCaixaFechamentoByIdAsync(id);
            if (cliente == null) return NotFound(new { message = "Fechamento não encontrado." });
            return Ok(cliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar fechamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-fechamento")]
    public async Task<IActionResult> CreateFechamento(CaixaFechamento fechamento)
    {
        try
        {
            await _caixaFechamentoService.AddCaixaFechamentoAsync(fechamento);
            return CreatedAtAction(nameof(GetFechamentoById), new { id = fechamento.Id }, fechamento);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de fechamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar fechamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-fechamento/{id:guid}")]
    public async Task<IActionResult> DeleteFechamento(Guid id)
    {
        try
        {
            await _caixaFechamentoService.DeleteCaixaFechamentoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar fechamento.", error = ex.Message });
        }
    }
}
