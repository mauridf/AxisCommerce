using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Application.Services.Produtos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Produtos;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Produtos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Produto)]
[Route("api/v{version:apiVersion}/[controller]")]
public class AtributosController : ControllerBase
{
    private readonly IProdutoAtributoService _produtoAtributoService;
    private readonly IProdutoAtributoDefinicaoService _produtoDefinicaoService;

    public AtributosController(IProdutoAtributoService produtoAtributoService, IProdutoAtributoDefinicaoService produtoDefinicaoService)
    {
        _produtoAtributoService = produtoAtributoService;
        _produtoDefinicaoService = produtoDefinicaoService;
    }

    [HttpGet("atributos")]
    public async Task<IActionResult> GetAllAtributos()
    {
        try
        {
            var atributos = await _produtoAtributoService.GetAllAsync();
            return Ok(atributos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os atributos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-atributo-por-id/{id:guid}")]
    public async Task<IActionResult> GetAtributoById(Guid id)
    {
        try
        {
            var atributo = await _produtoAtributoService.GetByIdAsync(id);
            if (atributo == null) return NotFound(new { message = "Atributo não encontrado." });
            return Ok(atributo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar atributo por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-atributo")]
    public async Task<IActionResult> CreateAtributo(ProdutoAtributo atributo)
    {
        try
        {
            await _produtoAtributoService.AddAsync(atributo);
            return CreatedAtAction(nameof(GetAtributoById), new { id = atributo.Id }, atributo);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar atributo.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar atributo.", error = ex.Message });
        }
    }

    [HttpPut("alterar-atributo/{id:guid}")]
    public async Task<IActionResult> UpdateAtributo(Guid id, ProdutoAtributo atributo)
    {
        try
        {
            if (id != atributo.Id) return BadRequest();
            await _produtoAtributoService.UpdateAsync(atributo);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar produto.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-produto/{id:guid}")]
    public async Task<IActionResult> DeleteProduto(Guid id)
    {
        try
        {
            await _produtoAtributoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar produto.", error = ex.Message });
        }
    }

    [HttpGet("definicoes-dos-atributos")]
    public async Task<IActionResult> GetAllDefinicoes()
    {
        try
        {
            var definicoes = await _produtoDefinicaoService.GetAllAsync();
            return Ok(definicoes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as definições dos atributos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-definicao-do-atributo-por-id/{id:guid}")]
    public async Task<IActionResult> GetDefinicaoById(Guid id)
    {
        try
        {
            var definicao = await _produtoDefinicaoService.GetByIdAsync(id);
            if (definicao == null) return NotFound(new { message = "Definição do Atributo não encontrado." });
            return Ok(definicao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar definição por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-definicao-do-atributo")]
    public async Task<IActionResult> CreateDesconto(ProdutoAtributoDefinicao definicao)
    {
        try
        {
            await _produtoDefinicaoService.AddAsync(definicao);
            return CreatedAtAction(nameof(GetDefinicaoById), new { id = definicao.Id }, definicao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar definição do atributo.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar definição do atributo.", error = ex.Message });
        }
    }

    [HttpPut("alterar-definicao-do-atributo/{id:guid}")]
    public async Task<IActionResult> UpdateDefinicao(Guid id, ProdutoAtributoDefinicao definicao)
    {
        try
        {
            if (id != definicao.Id) return BadRequest();
            await _produtoDefinicaoService.UpdateAsync(definicao);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar definição do atributo.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-definicao-atributo/{id:guid}")]
    public async Task<IActionResult> DeleteDefinicao(Guid id)
    {
        try
        {
            await _produtoDefinicaoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar definição do atributo.", error = ex.Message });
        }
    }
}
