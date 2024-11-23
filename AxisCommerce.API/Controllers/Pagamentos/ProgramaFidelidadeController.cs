using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Entities.Pagamento;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Pagamentos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Pagamento)]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProgramaFidelidadeController : ControllerBase
{
    private readonly IProgramaFidelidadeService _programaFidelidadeService;

    public ProgramaFidelidadeController(IProgramaFidelidadeService programaFidelidadeService)
    {
        _programaFidelidadeService = programaFidelidadeService;
    }

    [HttpGet("buscar-programas")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var programas = await _programaFidelidadeService.GetAllAsync();
            return Ok(programas);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os programas cadastrados.", error = ex.Message });
        }
    }

    [HttpGet("buscar-programa-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var programa = await _programaFidelidadeService.GetByIdAsync(id);
            if (programa == null) return NotFound(new { message = "Programa não encontrado." });
            return Ok(programa);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar programa por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-programa-fidelidade")]
    public async Task<IActionResult> Create(ProgramaFidelidade programa)
    {
        try
        {
            await _programaFidelidadeService.AddAsync(programa);
            return CreatedAtAction(nameof(GetById), new { id = programa.Id }, programa);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de programa de fildelidade.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar programa de fidelidade.", error = ex.Message });
        }
    }

    [HttpPut("alterar-programa/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, ProgramaFidelidade programa)
    {
        try
        {
            if (id != programa.Id) return BadRequest();
            await _programaFidelidadeService.UpdateAsync(programa);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar programa de fidelidade.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-programa/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _programaFidelidadeService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar programa de fidelidade.", error = ex.Message });
        }
    }
}
