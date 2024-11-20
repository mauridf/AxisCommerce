using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Clientes;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Cliente)]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProfissaoController : ControllerBase
{
    private readonly IClienteProfissaoService _clienteProfissaoService;

    public ProfissaoController(IClienteProfissaoService clienteProfissaoService)
    {
        _clienteProfissaoService = clienteProfissaoService;
    }

    [HttpGet("buscar-profissao-clientes")]
    public async Task<IActionResult> GetAllProfissoes()
    {
        try
        {
            var clientesProfissao = await _clienteProfissaoService.GetAllClienteProfissaoAsync();
            return Ok(clientesProfissao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as profissões de clientes.", error = ex.Message });
        }
    }

    [HttpGet("buscar-profissao-por-id/{id:guid}")]
    public async Task<IActionResult> GetProfissaoById(Guid id)
    {
        try
        {
            var clienteProfissao = await _clienteProfissaoService.GetClienteProfissaoByIdAsync(id);
            if (clienteProfissao == null) return NotFound(new { message = "Profissão não encontrada." });
            return Ok(clienteProfissao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar profissão por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-profissao")]
    public async Task<IActionResult> CreateProfissao(ClienteProfissao clienteProfissao)
    {
        try
        {
            await _clienteProfissaoService.AddClienteProfissaoAsync(clienteProfissao);
            return CreatedAtAction(nameof(GetProfissaoById), new { id = clienteProfissao.Id }, clienteProfissao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de profissão.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar profissão.", error = ex.Message });
        }
    }

    [HttpPut("alterar-profissao/{id:guid}")]
    public async Task<IActionResult> UpdateProfissao(Guid id, ClienteProfissao profissao)
    {
        try
        {
            if (id != profissao.Id) return BadRequest();
            await _clienteProfissaoService.UpdateClienteProfissaoAsync(profissao);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar profissão.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-profissao/{id:guid}")]
    public async Task<IActionResult> DeleteProfissao(Guid id)
    {
        try
        {
            await _clienteProfissaoService.DeleteClienteProfissaoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar profissão.", error = ex.Message });
        }
    }
}
