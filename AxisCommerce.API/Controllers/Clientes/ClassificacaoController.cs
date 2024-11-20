using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Clientes;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Cliente)]
[Route("api/v{version:apiVersion}/[controller]")]
public class ClassificacaoController : ControllerBase
{
    private readonly IClienteClassificacaoService _clienteClassificacaoService;
    
    public ClassificacaoController(IClienteClassificacaoService clienteClassificacaoService)
    {
        _clienteClassificacaoService = clienteClassificacaoService;
    }

    [HttpGet("buscar-classificacoes-clientes")]
    public async Task<IActionResult> GetAllClassificacao()
    {
        try
        {
            var clientesClassificacoes = await _clienteClassificacaoService.GetAllClienteClassificacaosAsync();
            return Ok(clientesClassificacoes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as classificações de clientes.", error = ex.Message });
        }
    }

    [HttpGet("buscar-classificacao-por-id/{id:guid}")]
    public async Task<IActionResult> GetClassificacaoById(Guid id)
    {
        try
        {
            var clienteClassificacao = await _clienteClassificacaoService.GetClienteClassificacaoByIdAsync(id);
            if (clienteClassificacao == null) return NotFound(new { message = "Classificaççao não encontrada." });
            return Ok(clienteClassificacao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar classificação por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-classificacao")]
    public async Task<IActionResult> CreateClassificacao(ClienteClassificacao clienteClassificacao)
    {
        try
        {
            await _clienteClassificacaoService.AddClienteClassificacaoAsync(clienteClassificacao);
            return CreatedAtAction(nameof(GetClassificacaoById), new { id = clienteClassificacao.Id }, clienteClassificacao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de classificação.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar classificação.", error = ex.Message });
        }
    }

    [HttpPut("alterar-classificacao/{id:guid}")]
    public async Task<IActionResult> UpdateClassificacao(Guid id, ClienteClassificacao classificacao)
    {
        try
        {
            if (id != classificacao.Id) return BadRequest();
            await _clienteClassificacaoService.UpdateClienteClassificacaoAsync(classificacao);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar classificação.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-classificacao/{id:guid}")]
    public async Task<IActionResult> DeleteClassificacao(Guid id)
    {
        try
        {
            await _clienteClassificacaoService.DeleteClienteClassificacaoAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar classificacao.", error = ex.Message });
        }
    }
}
