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
public class CondicaoPagtoController : ControllerBase
{
    private readonly ICondicaoPagtoService _condicaoPagtoService;
    private readonly ICondicaoPagtoParcelaService _condicaoParcelaService;

    public CondicaoPagtoController(ICondicaoPagtoService condicaoPagtoService, ICondicaoPagtoParcelaService condicaoParcelaService)
    {
        _condicaoPagtoService = condicaoPagtoService;
        _condicaoParcelaService = condicaoParcelaService;
    }

    [HttpGet("condicoes-de-pagamento")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var condicoesPagto = await _condicaoPagtoService.GetAllAsync();
            return Ok(condicoesPagto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todas as condições de pagamento.", error = ex.Message });
        }
    }

    [HttpGet("buscar-condicao-de-pagamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var condicaoPagto = await _condicaoPagtoService.GetByIdAsync(id);
            if (condicaoPagto == null) return NotFound(new { message = "Condição de Pagamento não encontrada." });
            return Ok(condicaoPagto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar condição de pagamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-condicao-pagamento")]
    public async Task<IActionResult> Create(CondicaoPagto condicaoPagto)
    {
        try
        {
            await _condicaoPagtoService.AddAsync(condicaoPagto);
            return CreatedAtAction(nameof(GetById), new { id = condicaoPagto.Id }, condicaoPagto);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de condição de pagamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar condição de pagamento.", error = ex.Message });
        }
    }

    [HttpPut("alterar-condicao-pagamento/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, CondicaoPagto condicaoPgto)
    {
        try
        {
            if (id != condicaoPgto.Id) return BadRequest();
            await _condicaoPagtoService.UpdateAsync(condicaoPgto);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar condição de pagamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-condicao-pagamento/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _condicaoPagtoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar condição de pagamento.", error = ex.Message });
        }
    }

    [HttpGet("pagamento-parcela")]
    public async Task<IActionResult> GetAllCondicaoParcela()
    {
        try
        {
            var pagamentosParcelas = await _condicaoParcelaService.GetAllAsync();
            return Ok(pagamentosParcelas);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de pagamento parcela.", error = ex.Message });
        }
    }

    [HttpGet("buscar-pagamento-parcela-por-id/{id:guid}")]
    public async Task<IActionResult> GetConcicaoParcelaById(Guid id)
    {
        try
        {
            var pagamentoParcela = await _condicaoParcelaService.GetByIdAsync(id);
            if (pagamentoParcela == null) return NotFound(new { message = "Pagamento parcela não encontrado." });
            return Ok(pagamentoParcela);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar pagamento parcela por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-pagamento-parcela")]
    public async Task<IActionResult> Create(CondicaoPagtoParcela pagamentoParcela)
    {
        try
        {
            await _condicaoParcelaService.AddAsync(pagamentoParcela);
            return CreatedAtAction(nameof(GetById), new { id = pagamentoParcela.Id }, pagamentoParcela);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de pagamento parcela.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar pagamento parcela.", error = ex.Message });
        }
    }

    [HttpPut("alterar-pagamento-parcela/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, CondicaoPagtoParcela pagamentoParcela)
    {
        try
        {
            if (id != pagamentoParcela.Id) return BadRequest();
            await _condicaoParcelaService.UpdateAsync(pagamentoParcela);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar pagamento parcela.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-pagamento-parcela/{id:guid}")]
    public async Task<IActionResult> DeletePagamentoParcela(Guid id)
    {
        try
        {
            await _condicaoParcelaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar pagamento parcela.", error = ex.Message });
        }
    }
}
