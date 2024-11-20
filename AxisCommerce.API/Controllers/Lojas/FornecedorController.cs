using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Loja;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Loja)]
[Route("api/v{version:apiVersion}/[controller]")]
public class FornecedorController : ControllerBase
{
    private readonly IFornecedorService _fornecedorService;

    public FornecedorController(IFornecedorService fornecedorService)
    {
        _fornecedorService = fornecedorService;
    }

    [HttpGet("buscar-todos-fornecedores")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var fornecedores = await _fornecedorService.GetAllAsync();
            return Ok(fornecedores);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os fornecedores.", error = ex.Message });
        }
    }

    [HttpGet("buscar-fornecedor-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var fornecedor = await _fornecedorService.GetByIdAsync(id);
            if (fornecedor == null) return NotFound(new { message = "Fornecedor não encontrado." });
            return Ok(fornecedor);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar fornecedor por ID.", error = ex.Message });
        }
    }

    [HttpGet("buscar-fornecedor-por-cnpj/{cnpj}")]
    public async Task<IActionResult> GetByCNPJ(string cnpj)
    {
        try
        {
            var fornecedor = await _fornecedorService.GetByCNPJ(cnpj);
            if (fornecedor == null) return NotFound(new { message = "Fornecedor não encontrado." });
            return Ok(fornecedor);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar fornecedor por CNPJ.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-fornecedor")]
    public async Task<IActionResult> Create(Fornecedor fornecedor)
    {
        try
        {
            await _fornecedorService.AddAsync(fornecedor);
            return CreatedAtAction(nameof(GetById), new { id = fornecedor.Id }, fornecedor);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro do fornecedor.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar fornecedor.", error = ex.Message });
        }
    }

    [HttpPut("alterar-fornecedor/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, Fornecedor fornecedor)
    {
        try
        {
            if (id != fornecedor.Id) return BadRequest();
            await _fornecedorService.UpdateAsync(fornecedor);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar fornecedor.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-fornecedor/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _fornecedorService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar fornecedor.", error = ex.Message });
        }
    }
}
