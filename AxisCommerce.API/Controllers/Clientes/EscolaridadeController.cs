using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Clientes;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Cliente)]
[Route("api/v{version:apiVersion}/[controller]")]
public class EscolaridadeController : ControllerBase
{
    private readonly IClienteEscolaridadeService _clienteEscolaridadeService;
    
    public EscolaridadeController(IClienteEscolaridadeService clienteEscolaridadeService)
    {
        _clienteEscolaridadeService = clienteEscolaridadeService;
    }

    [HttpGet("buscar-escolaridades-clientes")]
    public async Task<IActionResult> GetAllEscolaridade()
    {
        try
        {
            var clientesEscolaridade = await _clienteEscolaridadeService.GetAllClienteEscolaridadeAsync();
            return Ok(clientesEscolaridade);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as escolaridades de clientes.", error = ex.Message });
        }
    }

    [HttpGet("buscar-escolaridade-por-id/{id:guid}")]
    public async Task<IActionResult> GetEscolalidadeById(Guid id)
    {
        try
        {
            var clienteEscolaridade = await _clienteEscolaridadeService.GetClienteEscolaridadeByIdAsync(id);
            if (clienteEscolaridade == null) return NotFound(new { message = "Escolaridade não encontrada." });
            return Ok(clienteEscolaridade);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar escolaridade por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-escolaridade")]
    public async Task<IActionResult> CreateEscolaridade(ClienteEscolaridade clienteEscolaridade)
    {
        try
        {
            await _clienteEscolaridadeService.AddClienteEscolaridadeAsync(clienteEscolaridade);
            return CreatedAtAction(nameof(GetEscolalidadeById), new { id = clienteEscolaridade.Id }, clienteEscolaridade);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de escolaridade.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar escolaridade.", error = ex.Message });
        }
    }

    [HttpPut("alterar-escolaridade/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, ClienteEscolaridade escolaridade)
    {
        try
        {
            if (id != escolaridade.Id) return BadRequest();
            await _clienteEscolaridadeService.UpdateClienteEscolaridadeAsync(escolaridade);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar escolaridade.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-escolaridade/{id:guid}")]
    public async Task<IActionResult> DeleteEscolaridade(Guid id)
    {
        try
        {
            await _clienteEscolaridadeService.DeleteClienteEscolaridadeAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar escolaridade.", error = ex.Message });
        }
    }
}

