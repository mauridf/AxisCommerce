using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Loja;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Loja)]
[Route("api/v{version:apiVersion}/[controller]")]
public class LojaController : ControllerBase
{
    private readonly ILojaService _lojaService;

    public LojaController(ILojaService lojaService)
    {
        _lojaService = lojaService;
    }

    [HttpGet("buscar-todas-lojas")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var lojas = await _lojaService.GetAllAsync();
            return Ok(lojas);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as lojas.", error = ex.Message });
        }
    }

    [HttpGet("buscar-loja-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var loja = await _lojaService.GetByIdAsync(id);
            if (loja == null) return NotFound(new { message = "Loja não encontrada." });
            return Ok(loja);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar loja por ID.", error = ex.Message });
        }
    }

    [HttpGet("buscar-loja-por-codloja/{codLoja}")]
    public async Task<IActionResult> GetByCodLoja(string codLoja)
    {
        try
        {
            var loja = await _lojaService.GetByCodLoja(codLoja);
            if (loja == null) return NotFound(new { message = "Loja não encontrada." });
            return Ok(loja);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar loja por cod loja.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-loja")]
    public async Task<IActionResult> Create(Lojas loja)
    {
        try
        {
            await _lojaService.AddAsync(loja);
            return CreatedAtAction(nameof(GetById), new { id = loja.Id }, loja);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro da loja.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar loja.", error = ex.Message });
        }
    }

    [HttpPut("alterar-loja/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, Lojas loja)
    {
        try
        {
            if (id != loja.Id) return BadRequest();
            await _lojaService.UpdateAsync(loja);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar loja.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-loja/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _lojaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar loja.", error = ex.Message });
        }
    }
}
