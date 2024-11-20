using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Clientes;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Cliente)]
[Route("api/v{version:apiVersion}/[controller]")]
public class TipoController : ControllerBase
{
    private readonly IClienteTipoService _clienteTipoService;

    public TipoController(IClienteTipoService clienteTipoService)
    {
        _clienteTipoService = clienteTipoService;
    }

    [HttpGet("buscar-tipo")]
    public async Task<IActionResult> GetAllTipo()
    {
        try
        {
            var tipo = await _clienteTipoService.GetAllClienteTipoAsync();
            return Ok(tipo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tipo-por-id/{id:guid}")]
    public async Task<IActionResult> GetTipoById(Guid id)
    {
        try
        {
            var clienteTipo = await _clienteTipoService.GetClienteTipoByIdAsync(id);
            if (clienteTipo == null) return NotFound(new { message = "Tipo não encontrada." });
            return Ok(clienteTipo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tipo")]
    public async Task<IActionResult> CreateTipo(ClienteTipo clienteTipo)
    {
        try
        {
            await _clienteTipoService.AddClienteTipoAsync(clienteTipo);
            return CreatedAtAction(nameof(GetTipoById), new { id = clienteTipo.Id }, clienteTipo);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de tipo.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tipo.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tipo/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, ClienteTipo tipo)
    {
        try
        {
            if (id != tipo.Id) return BadRequest();
            await _clienteTipoService.UpdateClienteTipoAsync(tipo);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar tipo.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo/{id:guid}")]
    public async Task<IActionResult> DeleteTipo(Guid id)
    {
        try
        {
            await _clienteTipoService.DeleteClienteTipoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo.", error = ex.Message });
        }
    }
}
