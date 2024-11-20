using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Domain.Entities.Caixa;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Caixa;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Caixa)]
[Route("api/v{version:apiVersion}/[controller]")]
public class CaixaRecebimentoController : ControllerBase
{
    private readonly ICaixaRecebimentoPgtoService _caixaRecebimentoPgtoService;
    private readonly ICaixaRecebimentoService _caixaRecebimentoService;

    public CaixaRecebimentoController(
        ICaixaRecebimentoPgtoService caixaRecebimentoPgtoService,
        ICaixaRecebimentoService caixaRecebimentoService)
    {
        _caixaRecebimentoPgtoService = caixaRecebimentoPgtoService;
        _caixaRecebimentoService = caixaRecebimentoService;
    }
    [HttpGet("buscar-recebimentos-caixa")]
    public async Task<IActionResult> GetAllRecebimentos()
    {
        try
        {
            var recebimentos = await _caixaRecebimentoService.GetAllCaixaRecebimentoAsync();
            return Ok(recebimentos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os recebimentos de caixa.", error = ex.Message });
        }
    }

    [HttpGet("buscar-recebimento-por-id/{id:guid}")]
    public async Task<IActionResult> GetRecebimentoById(Guid id)
    {
        try
        {
            var recebimento = await _caixaRecebimentoService.GetCaixaRecebimentoByIdAsync(id);
            if (recebimento == null) return NotFound(new { message = "Recebimento não encontrado." });
            return Ok(recebimento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar recebimento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-recebimento")]
    public async Task<IActionResult> CreateRecebimento(CaixaRecebimento recebimento)
    {
        try
        {
            await _caixaRecebimentoService.AddCaixaRecebimentoAsync(recebimento);
            return CreatedAtAction(nameof(GetRecebimentoById), new { id = recebimento.Id }, recebimento);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de recebimento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar recebimento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-recebimento/{id:guid}")]
    public async Task<IActionResult> DeleteRecebimento(Guid id)
    {
        try
        {
            await _caixaRecebimentoService.DeleteCaixaRecebimentoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar recebimento.", error = ex.Message });
        }
    }

    [HttpGet("buscar-pagamento-recebimentos")]
    public async Task<IActionResult> GetAllPagtosRecebimento()
    {
        try
        {
            var pagtoRecebimentos = await _caixaRecebimentoPgtoService.GetAllCaixaRecebimentoPgtoAsync();
            return Ok(pagtoRecebimentos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os pagamentos de recebimentos de caixa.", error = ex.Message });
        }
    }

    [HttpGet("buscar-pagamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetPagamentoById(Guid id)
    {
        try
        {
            var pagamento = await _caixaRecebimentoPgtoService.GetCaixaRecebimentoPgtoByIdAsync(id);
            if (pagamento == null) return NotFound(new { message = "Pagamento não encontrado." });
            return Ok(pagamento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar pagamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-pagamento")]
    public async Task<IActionResult> CreatePagamento(CaixaRecebimentoPgto pagamento)
    {
        try
        {
            await _caixaRecebimentoPgtoService.AddCaixaRecebimentoPgtoAsync(pagamento);
            return CreatedAtAction(nameof(GetPagamentoById), new { id = pagamento.Id }, pagamento);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de pagamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar pagamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-pagamento/{id:guid}")]
    public async Task<IActionResult> DeletePagamento(Guid id)
    {
        try
        {
            await _caixaRecebimentoPgtoService.DeleteCaixaRecebimentoPgtoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar pagamento.", error = ex.Message });
        }
    }
}
