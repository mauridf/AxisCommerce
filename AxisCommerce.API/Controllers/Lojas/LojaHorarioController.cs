using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Loja;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Loja)]
[Route("api/v{version:apiVersion}/[controller]")]
public class LojaHorarioController : ControllerBase
{
    private readonly ILojaHorarioService _lojaHorarioService;

    public LojaHorarioController(ILojaHorarioService lojaHorarioService)
    {
        _lojaHorarioService = lojaHorarioService;
    }

    [HttpGet("buscar-horarios")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var horarios = await _lojaHorarioService.GetAllAsync();
            return Ok(horarios);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os horarios.", error = ex.Message });
        }
    }

    [HttpGet("horario-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var horario = await _lojaHorarioService.GetByIdAsync(id);
            if (horario == null) return NotFound(new { message = "Horario não encontrada." });
            return Ok(horario);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar horario por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-horario")]
    public async Task<IActionResult> Create(LojaHorario horario)
    {
        try
        {
            await _lojaHorarioService.AddAsync(horario);
            return CreatedAtAction(nameof(GetById), new { id = horario.Id }, horario);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de horario.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar horario.", error = ex.Message });
        }
    }

    [HttpPut("alterar-horario/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, LojaHorario horario)
    {
        try
        {
            if (id != horario.Id) return BadRequest();
            await _lojaHorarioService.UpdateAsync(horario);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar horario.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-horario/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _lojaHorarioService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar horario.", error = ex.Message });
        }
    }
}
