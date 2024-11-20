using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Loja;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Loja)]
[Route("api/v{version:apiVersion}/[controller]")]
public class TerminalController : ControllerBase
{
    private readonly ITerminalService _terminalService;

    public TerminalController(ITerminalService terminalService)
    {
        _terminalService = terminalService;
    }

    [HttpGet("terminais")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var terminais = await _terminalService.GetAllAsync();
            return Ok(terminais);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os terminais.", error = ex.Message });
        }
    }

    [HttpGet("terminal-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var terminal = await _terminalService.GetByIdAsync(id);
            if (terminal == null) return NotFound(new { message = "Terminal não encontrada." });
            return Ok(terminal);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar terminal por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-terminal")]
    public async Task<IActionResult> Create(Terminal terminal)
    {
        try
        {
            await _terminalService.AddAsync(terminal);
            return CreatedAtAction(nameof(GetById), new { id = terminal.Id }, terminal);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de terminal.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar terminal.", error = ex.Message });
        }
    }

    [HttpPut("alterar-terminal/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, Terminal terminal)
    {
        try
        {
            if (id != terminal.Id) return BadRequest();
            await _terminalService.UpdateAsync(terminal);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar terminal.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-terminal/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _terminalService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar terminal.", error = ex.Message });
        }
    }
}
