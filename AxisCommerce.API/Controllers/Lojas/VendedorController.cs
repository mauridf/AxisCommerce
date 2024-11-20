using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Loja;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Loja)]
[Route("api/v{version:apiVersion}/[controller]")]
public class VendedorController : ControllerBase
{
    private readonly IVendedorService _vendedorService;

    public VendedorController(IVendedorService vendedorService)
    {
        _vendedorService = vendedorService;
    }

    [HttpGet("vendedores")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var vendedores = await _vendedorService.GetAllAsync();
            return Ok(vendedores);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os vendedores.", error = ex.Message });
        }
    }

    [HttpGet("gerentes")]
    public async Task<IActionResult> GetAllGerentes()
    {
        try
        {
            var vendedores = await _vendedorService.GetGerentesAsync();
            return Ok(vendedores);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os gerentes.", error = ex.Message });
        }
    }

    [HttpGet("operadores")]
    public async Task<IActionResult> GetAllOperadores()
    {
        try
        {
            var vendedores = await _vendedorService.GetOperadoresAsync();
            return Ok(vendedores);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os operadores.", error = ex.Message });
        }
    }

    [HttpGet("vendedor-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var vendedor = await _vendedorService.GetByIdAsync(id);
            if (vendedor == null) return NotFound(new { message = "Vendedor não encontrado." });
            return Ok(vendedor);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar vendedor por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-vendedor")]
    public async Task<IActionResult> Create(Vendedor vendedor)
    {
        try
        {
            await _vendedorService.AddAsync(vendedor);
            return CreatedAtAction(nameof(GetById), new { id = vendedor.Id }, vendedor);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de vendedor.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar vendedor.", error = ex.Message });
        }
    }

    [HttpPut("alterar-vendedor/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, Vendedor vendedor)
    {
        try
        {
            if (id != vendedor.Id) return BadRequest();
            await _vendedorService.UpdateAsync(vendedor);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar vendedor.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-vendedor/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _vendedorService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar vendedor.", error = ex.Message });
        }
    }
}
