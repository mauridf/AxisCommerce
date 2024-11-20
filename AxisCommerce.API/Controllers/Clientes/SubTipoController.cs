using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Clientes;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Cliente)]
[Route("api/v{version:apiVersion}/[controller]")]
public class SubTipoController : ControllerBase
{
    private readonly IClienteSubTipoService _clienteSubTipoService;

    public SubTipoController(IClienteSubTipoService clienteSubTipoService)
    {
        _clienteSubTipoService = clienteSubTipoService;
    }

    [HttpGet("buscar-subtipos")]
    public async Task<IActionResult> GetAllSubTipo()
    {
        try
        {
            var subTipo = await _clienteSubTipoService.GetAllClienteSubTipoAsync();
            return Ok(subTipo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os subtipos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-subtipo-por-id/{id:guid}")]
    public async Task<IActionResult> GetSubTipoById(Guid id)
    {
        try
        {
            var clienteSubTipo = await _clienteSubTipoService.GetClienteSubTipoByIdAsync(id);
            if (clienteSubTipo == null) return NotFound(new { message = "SubTipo não encontrada." });
            return Ok(clienteSubTipo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar subtipo por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-subtipo")]
    public async Task<IActionResult> CreateSubTipo(ClienteSubTipo clienteSubTipo)
    {
        try
        {
            await _clienteSubTipoService.AddClienteSubTipoAsync(clienteSubTipo);
            return CreatedAtAction(nameof(GetSubTipoById), new { id = clienteSubTipo.Id }, clienteSubTipo);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de subtipo.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar subtipo.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-subtipo/{id:guid}")]
    public async Task<IActionResult> DeleteSubTipo(Guid id)
    {
        try
        {
            await _clienteSubTipoService.DeleteClienteSubTipoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar subtipo.", error = ex.Message });
        }
    }
}
