using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Produtos;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Produtos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Produto)]
[Route("api/v{version:apiVersion}/[controller]")]
public class LogisticoController : ControllerBase
{
    private readonly IDepositoService _depositoService;
    private readonly IEstoqueService _estoqueService;

    public LogisticoController(IDepositoService depositoService, IEstoqueService estoqueService)
    {
        _depositoService = depositoService;
        _estoqueService = estoqueService;
    }

    [HttpGet("depositos")]
    public async Task<IActionResult> GetAllDepositos()
    {
        try
        {
            var depositos = await _depositoService.GetAllAsync();
            return Ok(depositos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os depositos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-deposito-por-id/{id:guid}")]
    public async Task<IActionResult> GetDepositoById(Guid id)
    {
        try
        {
            var deposito = await _depositoService.GetByIdAsync(id);
            if (deposito == null) return NotFound(new { message = "Deposito não encontrado." });
            return Ok(deposito);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar deposito por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-deposito")]
    public async Task<IActionResult> CreateDeposito(Deposito deposito)
    {
        try
        {
            await _depositoService.AddAsync(deposito);
            return CreatedAtAction(nameof(GetDepositoById), new { id = deposito.Id }, deposito);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar deposito.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar deposito.", error = ex.Message });
        }
    }

    [HttpPut("alterar-deposito/{id:guid}")]
    public async Task<IActionResult> UpdateDeposito(Guid id, Deposito deposito)
    {
        try
        {
            if (id != deposito.Id) return BadRequest();
            await _depositoService.UpdateAsync(deposito);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar deposito.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-deposito/{id:guid}")]
    public async Task<IActionResult> DeleteDeposito(Guid id)
    {
        try
        {
            await _depositoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar deposito.", error = ex.Message });
        }
    }

    [HttpGet("estoques")]
    public async Task<IActionResult> GetAllEstoques()
    {
        try
        {
            var estoques = await _estoqueService.GetAllAsync();
            return Ok(estoques);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os estoques.", error = ex.Message });
        }
    }

    [HttpGet("buscar-estoque-por-id/{id:guid}")]
    public async Task<IActionResult> GetEstoqueById(Guid id)
    {
        try
        {
            var estoque = await _estoqueService.GetByIdAsync(id);
            if (estoque == null) return NotFound(new { message = "Estoque não encontrado." });
            return Ok(estoque);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar estoque por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-estoque")]
    public async Task<IActionResult> CreateEstoque(Estoque estoque)
    {
        try
        {
            await _estoqueService.AddAsync(estoque);
            return CreatedAtAction(nameof(GetEstoqueById), new { id = estoque.Id }, estoque);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar estoque.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar estoque.", error = ex.Message });
        }
    }

    [HttpPut("alterar-estoque/{id:guid}")]
    public async Task<IActionResult> UpdateEstoque(Guid id, Estoque estoque)
    {
        try
        {
            if (id != estoque.Id) return BadRequest();
            await _estoqueService.UpdateAsync(estoque);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar estoque.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-estoque/{id:guid}")]
    public async Task<IActionResult> DeleteEstoque(Guid id)
    {
        try
        {
            await _estoqueService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar estoque.", error = ex.Message });
        }
    }
}
