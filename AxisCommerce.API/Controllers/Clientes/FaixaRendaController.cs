using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Clientes;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Cliente)]
[Route("api/v{version:apiVersion}/[controller]")]
public class FaixaRendaController : ControllerBase
{
    private readonly IClienteFaixaRendaService _clienteFaixaRendaService;
    
    public FaixaRendaController(IClienteFaixaRendaService clienteFaixaRendaService)
    {
        _clienteFaixaRendaService = clienteFaixaRendaService;
    }

    [HttpGet("buscar-faixa-renda-clientes")]
    public async Task<IActionResult> GetAllFaixaRenda()
    {
        try
        {
            var clientesFaixaRenda = await _clienteFaixaRendaService.GetAllClienteFaixaAsync();
            return Ok(clientesFaixaRenda);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as faixas de renda de clientes.", error = ex.Message });
        }
    }

    [HttpGet("buscar-faixa-de-renda-por-id/{id:guid}")]
    public async Task<IActionResult> GetFaixaRendaById(Guid id)
    {
        try
        {
            var clienteFaixaRenda = await _clienteFaixaRendaService.GetClienteFaixaByIdAsync(id);
            if (clienteFaixaRenda == null) return NotFound(new { message = "Faixa de Renda não encontrada." });
            return Ok(clienteFaixaRenda);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar faixa de renda por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-faixa-renda")]
    public async Task<IActionResult> CreateFaixaRenda(ClienteFaixaRenda clienteFaixaRenda)
    {
        try
        {
            await _clienteFaixaRendaService.AddClienteFaixaAsync(clienteFaixaRenda);
            return CreatedAtAction(nameof(GetFaixaRendaById), new { id = clienteFaixaRenda.Id }, clienteFaixaRenda);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de faixa de renda.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar faixa de renda.", error = ex.Message });
        }
    }

    [HttpPut("alterar-faixa-renda/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, ClienteFaixaRenda faixaRenda)
    {
        try
        {
            if (id != faixaRenda.Id) return BadRequest();
            await _clienteFaixaRendaService.UpdateClienteFaixaAsync(faixaRenda);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar faixa de renda.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-faixa-renda/{id:guid}")]
    public async Task<IActionResult> DeleteFaixaRenda(Guid id)
    {
        try
        {
            await _clienteFaixaRendaService.DeleteClienteFaixaAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar faixa de renda.", error = ex.Message });
        }
    }
}
