using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Application.Services.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Pagamentos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Pagamento)]
[Route("api/v{version:apiVersion}/[controller]")]
public class PagamentoController : ControllerBase
{
    private readonly IMoedaIndicadorService _moedaIndicadorService;
    private readonly ITipoPagamentoService _tipoPagamentoService;

    public PagamentoController(IMoedaIndicadorService moedaIndicadorService, ITipoPagamentoService tipoPagamentoService)
    {
        _moedaIndicadorService = moedaIndicadorService;
        _tipoPagamentoService = tipoPagamentoService;
    }

    [HttpGet("moedas")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var moedas = await _moedaIndicadorService.GetAllAsync();
            return Ok(moedas);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as moedas cadastrados.", error = ex.Message });
        }
    }

    [HttpGet("buscar-moeda-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var moeda = await _moedaIndicadorService.GetByIdAsync(id);
            if (moeda == null) return NotFound(new { message = "Moeda não encontrado." });
            return Ok(moeda);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar moeda por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-moeda")]
    public async Task<IActionResult> Create(MoedaIndicador moeda)
    {
        try
        {
            await _moedaIndicadorService.AddAsync(moeda);
            return CreatedAtAction(nameof(GetById), new { id = moeda.Id }, moeda);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de moeda.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar moeda.", error = ex.Message });
        }
    }

    [HttpPut("alterar-moeda/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, MoedaIndicador moeda)
    {
        try
        {
            if (id != moeda.Id) return BadRequest();
            await _moedaIndicadorService.UpdateAsync(moeda);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao atualizar moeda.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-moeda/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _moedaIndicadorService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar moeda.", error = ex.Message });
        }
    }

    [HttpGet("tipos-pagamento")]
    public async Task<IActionResult> GetAllTipoPagto()
    {
        try
        {
            var tipoPgtos = await _tipoPagamentoService.GetAllAsync();
            return Ok(tipoPgtos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de pagamentos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tipo-pagamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetTipoPagtoById(Guid id)
    {
        try
        {
            var tipoPagto = await _tipoPagamentoService.GetByIdAsync(id);
            if (tipoPagto == null) return NotFound(new { message = "Tipo Pagamento não encontrado." });
            return Ok(tipoPagto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo pagamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tipo-pagamento")]
    public async Task<IActionResult> Create(TipoPagamento tipoPagto)
    {
        try
        {
            await _tipoPagamentoService.AddAsync(tipoPagto);
            return CreatedAtAction(nameof(GetById), new { id = tipoPagto.Id }, tipoPagto);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de tipo de pagamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tipo de pagamento.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tipo-pagamento/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, TipoPagamento tipoPagto)
    {
        try
        {
            if (id != tipoPagto.Id) return BadRequest();
            await _tipoPagamentoService.UpdateAsync(tipoPagto);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao atualizar tipo de pagamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo-pagamento/{id:guid}")]
    public async Task<IActionResult> DeleteTipoPagto(Guid id)
    {
        try
        {
            await _tipoPagamentoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo de pagamento.", error = ex.Message });
        }
    }
}
