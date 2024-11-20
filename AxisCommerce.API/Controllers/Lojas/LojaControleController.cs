using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Loja;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Loja)]
[Route("api/v{version:apiVersion}/[controller]")]
public class LojaControleController : ControllerBase
{
    private readonly ILojaControleService _lojaControleService;

    public LojaControleController(ILojaControleService lojaControleService)
    {
        _lojaControleService = lojaControleService;
    }

    [HttpGet("buscar-controles-lojas")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var controles = await _lojaControleService.GetAllAsync();
            return Ok(controles);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os controles.", error = ex.Message });
        }
    }

    [HttpGet("buscar-controle-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var controle = await _lojaControleService.GetByIdAsync(id);
            if (controle == null) return NotFound(new { message = "Controle não encontrada." });
            return Ok(controle);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar controle por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-controle-loja")]
    public async Task<IActionResult> Create(LojaControle controle)
    {
        try
        {
            await _lojaControleService.AddAsync(controle);
            return CreatedAtAction(nameof(GetById), new { id = controle.Id }, controle);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de controle.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar controle.", error = ex.Message });
        }
    }

    [HttpPut("alterar-controle-loja/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, LojaControle controle)
    {
        try
        {
            if (id != controle.Id) return BadRequest();
            await _lojaControleService.UpdateAsync(controle);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar controle.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-controle-loja/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _lojaControleService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar controle.", error = ex.Message });
        }
    }
}
