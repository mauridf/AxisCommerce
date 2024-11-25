using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Vendas;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Vendas;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Venda)]
[Route("api/v{version:apiVersion}/[controller]")]
public class PromocaoController : ControllerBase
{
    private readonly IPromocaoService _promocaoService;
    private readonly IPromocaoGrupoService _promocaoGrupoService;
    private readonly IPromocaoTipoOfertaService _promocaoTipoOfertaService;
    private readonly ITipoOfertaService _tipoOfertaService;

    public PromocaoController(IPromocaoService promocaoService, IPromocaoGrupoService promocaoGrupoService, IPromocaoTipoOfertaService promocaoTipoOfertaService, ITipoOfertaService tipoOfertaService)
    {
        _promocaoService = promocaoService;
        _promocaoGrupoService = promocaoGrupoService;
        _promocaoTipoOfertaService = promocaoTipoOfertaService;
        _tipoOfertaService = tipoOfertaService;
    }

    [HttpGet("promocoes")]
    public async Task<IActionResult> GetAllPromocoes()
    {
        try
        {
            var promocoes = await _promocaoService.GetAllAsync();
            return Ok(promocoes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as promoções.", error = ex.Message });
        }
    }

    [HttpGet("buscar-promocao-por-id/{id:guid}")]
    public async Task<IActionResult> GetPromocaoById(Guid id)
    {
        try
        {
            var promocao = await _promocaoService.GetByIdAsync(id);
            if (promocao == null) return NotFound(new { message = "Promoção não encontrado." });
            return Ok(promocao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar promoção por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-promocao")]
    public async Task<IActionResult> CreatePromocao(Promocao promocao)
    {
        try
        {
            await _promocaoService.AddAsync(promocao);
            return CreatedAtAction(nameof(GetPromocaoById), new { id = promocao.Id }, promocao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar promoção.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar promoção.", error = ex.Message });
        }
    }

    [HttpPut("alterar-promocao/{id:guid}")]
    public async Task<IActionResult> UpdatePromocao(Guid id, Promocao promocao)
    {
        try
        {
            if (id != promocao.Id) return BadRequest();
            await _promocaoService.UpdateAsync(promocao);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar promoção.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-promocao/{id:guid}")]
    public async Task<IActionResult> DeletePromocao(Guid id)
    {
        try
        {
            await _promocaoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar promoção.", error = ex.Message });
        }
    }

    [HttpGet("grupos-de-promocao")]
    public async Task<IActionResult> GetAllPromocaoGrupo()
    {
        try
        {
            var grupos = await _promocaoGrupoService.GetAllAsync();
            return Ok(grupos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os grupos de promoção.", error = ex.Message });
        }
    }

    [HttpGet("buscar-grupo-de-promocao-por-id/{id:guid}")]
    public async Task<IActionResult> GetGrupoById(Guid id)
    {
        try
        {
            var grupo = await _promocaoGrupoService.GetByIdAsync(id);
            if (grupo == null) return NotFound(new { message = "Grupo de Promoção não encontrado." });
            return Ok(grupo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar grupo de promoção por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-grupo-de-promocao")]
    public async Task<IActionResult> CreatePromocaoGrupo(PromocaoGrupo grupo)
    {
        try
        {
            await _promocaoGrupoService.AddAsync(grupo);
            return CreatedAtAction(nameof(GetGrupoById), new { id = grupo.Id }, grupo);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar grupo de promoção.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar grupo de promoção.", error = ex.Message });
        }
    }

    [HttpPut("alterar-grupo-de-promocao/{id:guid}")]
    public async Task<IActionResult> UpdateGrupo(Guid id, PromocaoGrupo grupo)
    {
        try
        {
            if (id != grupo.Id) return BadRequest();
            await _promocaoGrupoService.UpdateAsync(grupo);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar grupo de promoção.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-grupo/{id:guid}")]
    public async Task<IActionResult> DeleteGrupo(Guid id)
    {
        try
        {
            await _promocaoGrupoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar grupo de promoção.", error = ex.Message });
        }
    }

    [HttpGet("tipos-de-oferta")]
    public async Task<IActionResult> GetAllTiposOferta()
    {
        try
        {
            var tiposOferta = await _tipoOfertaService.GetAllAsync();
            return Ok(tiposOferta);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de oferta.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tipo-de-oferta-por-id/{id:guid}")]
    public async Task<IActionResult> GetTipoOfertaById(Guid id)
    {
        try
        {
            var tipoOferta = await _tipoOfertaService.GetByIdAsync(id);
            if (tipoOferta == null) return NotFound(new { message = "Tipo de Oferta não encontrado." });
            return Ok(tipoOferta);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo de oferta por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tipo-de-oferta")]
    public async Task<IActionResult> CreateTipoOferta(TipoOferta tipoOferta)
    {
        try
        {
            await _tipoOfertaService.AddAsync(tipoOferta);
            return CreatedAtAction(nameof(GetTipoOfertaById), new { id = tipoOferta.Id }, tipoOferta);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar tipo de oferta.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tipo de oferta.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tipo-oferta/{id:guid}")]
    public async Task<IActionResult> UpdateTipoOferta(Guid id, TipoOferta tipoOferta)
    {
        try
        {
            if (id != tipoOferta.Id) return BadRequest();
            await _tipoOfertaService.UpdateAsync(tipoOferta);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar tipo de oferta.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo-de-oferta/{id:guid}")]
    public async Task<IActionResult> DeleteTipoOferta(Guid id)
    {
        try
        {
            await _tipoOfertaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo de oferta.", error = ex.Message });
        }
    }

    [HttpGet("promocao-tipo-oferta")]
    public async Task<IActionResult> GetAllPromocaoTipoOferta()
    {
        try
        {
            var promocaoTipoOferta = await _promocaoTipoOfertaService.GetAllAsync();
            return Ok(promocaoTipoOferta);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de ofertas da promoção.", error = ex.Message });
        }
    }

    [HttpGet("buscar-promocao-tipo-oferta-por-id/{id:guid}")]
    public async Task<IActionResult> GetPromocaoTipoOfertaById(Guid id)
    {
        try
        {
            var promocaoTipoOferta = await _promocaoTipoOfertaService.GetByIdAsync(id);
            if (promocaoTipoOferta == null) return NotFound(new { message = "Tipo de Oferta da Promoção não encontrado." });
            return Ok(promocaoTipoOferta);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo de oferta da promoção por ID.", error = ex.Message });
        }
    }

    [HttpPost("incluir-tipo-de-oferta-da-promocao")]
    public async Task<IActionResult> CreateDesconto(PromocaoTipoOferta promocaoTipoOferta)
    {
        try
        {
            await _promocaoTipoOfertaService.AddAsync(promocaoTipoOferta);
            return CreatedAtAction(nameof(GetPromocaoTipoOfertaById), new { id = promocaoTipoOferta.Id }, promocaoTipoOferta);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar desconto.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar desconto.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tipo-de-oferta-da-promocao/{id:guid}")]
    public async Task<IActionResult> UpdatePromocaoTipoOferta(Guid id, PromocaoTipoOferta promocaoTipoOferta)
    {
        try
        {
            if (id != promocaoTipoOferta.Id) return BadRequest();
            await _promocaoTipoOfertaService.UpdateAsync(promocaoTipoOferta);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar tipo de oferta da promoção.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo-de-oferta-da-promocao/{id:guid}")]
    public async Task<IActionResult> DeletePromocaoTipoOferta(Guid id)
    {
        try
        {
            await _promocaoTipoOfertaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo de oferta da promoção.", error = ex.Message });
        }
    }
}
