using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Domain.Entities.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Clientes;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Cliente)]
[Route("api/v{version:apiVersion}/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet("buscar-todos-clientes")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var clientes = await _clienteService.GetAllClientesAsync();
            return Ok(clientes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os clientes.", error = ex.Message });
        }
    }

    [HttpGet("buscar-cliente-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var cliente = await _clienteService.GetClienteByIdAsync(id);
            if (cliente == null) return NotFound(new { message = "Cliente não encontrado." });
            return Ok(cliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar cliente por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-cliente")]
    public async Task<IActionResult> Create(Cliente cliente)
    {
        try
        {
            await _clienteService.AddClienteAsync(cliente);
            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro do cliente.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar cliente.", error = ex.Message });
        }
    }

    [HttpPut("alterar-cliente/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, Cliente cliente)
    {
        try
        {
            if (id != cliente.Id) return BadRequest();
            await _clienteService.UpdateClienteAsync(cliente);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar cliente.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-cliente/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _clienteService.DeleteClienteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar cliente.", error = ex.Message });
        }
    }
}
