using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Caixa;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Caixa)]
[Route("api/v{version:apiVersion}/[controller]")]
public class CaixaLancamentoController : ControllerBase
{
    private readonly ICaixaLancamentoService _caixaLancamentoService;
    private readonly ITipoLancamentoService _tipoLancamentoService;

    public CaixaLancamentoController(ICaixaLancamentoService caixaLancamentoService, ITipoLancamentoService tipoLancamentoService)
    {
        _caixaLancamentoService = caixaLancamentoService;
        _tipoLancamentoService = tipoLancamentoService;
    }

    [HttpGet("buscar-lancamentos-caixa")]
    public async Task<IActionResult> GetAllLancamentos()
    {
        try
        {
            var lancamentos = await _caixaLancamentoService.GetAllCaixaLancamentoAsync();
            return Ok(lancamentos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os lançamentos de caixa.", error = ex.Message });
        }
    }

    [HttpGet("buscar-lancamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetLancamentoById(Guid id)
    {
        try
        {
            var lancamento = await _caixaLancamentoService.GetCaixaLancamentoByIdAsync(id);
            if (lancamento == null) return NotFound(new { message = "Lançamento não encontrado." });
            return Ok(lancamento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar lançamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-lancamento")]
    public async Task<IActionResult> CreateLancamento(CaixaLancamento lancamento)
    {
        try
        {
            await _caixaLancamentoService.AddCaixaLancamentoAsync(lancamento);
            return CreatedAtAction(nameof(GetLancamentoById), new { id = lancamento.Id }, lancamento);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de lançamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar lançamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-lancamento/{id:guid}")]
    public async Task<IActionResult> DeleteLancamento(Guid id)
    {
        try
        {
            await _caixaLancamentoService.DeleteCaixaLancamentoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar lançamento.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tipos-lancamentos")]
    public async Task<IActionResult> GetAllTiposLancamentos()
    {
        try
        {
            var tiposLancamento = await _tipoLancamentoService.GetAllTipoLancamentoAsync();
            return Ok(tiposLancamento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de lançamentos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tipo-lancamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetTipoLancamentoById(Guid id)
    {
        try
        {
            var tipolancamento = await _tipoLancamentoService.GetTipoLancamentoByIdAsync(id);
            if (tipolancamento == null) return NotFound(new { message = "Tipo Lançamento não encontrado." });
            return Ok(tipolancamento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo lançamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tipo-lancamento")]
    public async Task<IActionResult> CreateTipoLancamento(TipoLancamento tipolancamento)
    {
        try
        {
            await _tipoLancamentoService.AddTipoLancamentoAsync(tipolancamento);
            return CreatedAtAction(nameof(GetTipoLancamentoById), new { id = tipolancamento.Id }, tipolancamento);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de tipo lançamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tipo lançamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo-lancamento/{id:guid}")]
    public async Task<IActionResult> DeleteTipoLancamento(Guid id)
    {
        try
        {
            await _tipoLancamentoService.DeleteTipoLancamentoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo lançamento.", error = ex.Message });
        }
    }
}
