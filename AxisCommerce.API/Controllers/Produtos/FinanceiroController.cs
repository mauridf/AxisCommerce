using AxisCommerce.API.Atributes;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Produtos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Produto)]
[Route("api/v{version:apiVersion}/[controller]")]
public class FinanceiroController : ControllerBase
{
    private readonly IProdutoTributoRepository _produtoTributoRepository;
    private readonly IProdutoPrecoRepository _produtoPrecoRepository;

    public FinanceiroController(IProdutoTributoRepository produtoTributoRepository, IProdutoPrecoRepository produtoPrecoRepository)
    {
        _produtoTributoRepository = produtoTributoRepository;
        _produtoPrecoRepository = produtoPrecoRepository;
    }

    [HttpGet("tributos")]
    public async Task<IActionResult> GetAllTributos()
    {
        try
        {
            var tributos = await _produtoTributoRepository.GetAllAsync();
            return Ok(tributos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tributos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tributo-por-id/{id:guid}")]
    public async Task<IActionResult> GetTributoById(Guid id)
    {
        try
        {
            var tributo = await _produtoTributoRepository.GetByIdAsync(id);
            if (tributo == null) return NotFound(new { message = "Tributo não encontrado." });
            return Ok(tributo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tributo por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tributo")]
    public async Task<IActionResult> CreateTributo(ProdutoTributo tributo)
    {
        try
        {
            await _produtoTributoRepository.AddAsync(tributo);
            return CreatedAtAction(nameof(GetTributoById), new { id = tributo.Id }, tributo);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar tributo.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tributo.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tributo/{id:guid}")]
    public async Task<IActionResult> UpdateTributo(Guid id, ProdutoTributo tributo)
    {
        try
        {
            if (id != tributo.Id) return BadRequest();
            await _produtoTributoRepository.UpdateAsync(tributo);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar tributo.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tributo/{id:guid}")]
    public async Task<IActionResult> DeleteTributo(Guid id)
    {
        try
        {
            await _produtoTributoRepository.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tributo.", error = ex.Message });
        }
    }

    [HttpGet("precos")]
    public async Task<IActionResult> GetAllPrecos()
    {
        try
        {
            var precos = await _produtoPrecoRepository.GetAllAsync();
            return Ok(precos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os preços.", error = ex.Message });
        }
    }

    [HttpGet("buscar-preco-por-id/{id:guid}")]
    public async Task<IActionResult> GetPrecoById(Guid id)
    {
        try
        {
            var preco = await _produtoPrecoRepository.GetByIdAsync(id);
            if (preco == null) return NotFound(new { message = "Preço não encontrado." });
            return Ok(preco);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar preço por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-preco")]
    public async Task<IActionResult> CreatePreco(ProdutoPreco preco)
    {
        try
        {
            await _produtoPrecoRepository.AddAsync(preco);
            return CreatedAtAction(nameof(GetPrecoById), new { id = preco.Id }, preco);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar preço.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar preço.", error = ex.Message });
        }
    }

    [HttpPut("alterar-preco/{id:guid}")]
    public async Task<IActionResult> UpdatePreco(Guid id, ProdutoPreco preco)
    {
        try
        {
            if (id != preco.Id) return BadRequest();
            await _produtoPrecoRepository.UpdateAsync(preco);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar preço.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-preco/{id:guid}")]
    public async Task<IActionResult> DeletePreco(Guid id)
    {
        try
        {
            await _produtoPrecoRepository.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar preço.", error = ex.Message });
        }
    }
}
