using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Application.Services.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Pagamentos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Pagamento)]
[Route("api/v{version:apiVersion}/[controller]")]
public class AdminCartaoController : ControllerBase
{
    private readonly IAdminCartaoService _adminCartaoService;
    private readonly ICredenciadoraCartaoService _credenciadoraCartaoService;

    public AdminCartaoController(IAdminCartaoService adminCartaoService, ICredenciadoraCartaoService credenciadoraCartaoService)
    {
        _adminCartaoService = adminCartaoService;
        _credenciadoraCartaoService = credenciadoraCartaoService;
    }

    [HttpGet("administradoras-de-cartao")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var adminCartoes = await _adminCartaoService.GetAllAsync();
            return Ok(adminCartoes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todas as administradoras de cartão.", error = ex.Message });
        }
    }

    [HttpGet("buscar-administradora-de-cartao-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var adminCartao = await _adminCartaoService.GetByIdAsync(id);
            if (adminCartao == null) return NotFound(new { message = "Administradora de Cartão não encontrada." });
            return Ok(adminCartao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar administradora de cartão por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-administradora-de-cartao")]
    public async Task<IActionResult> Create(AdminCartao adminCartao)
    {
        try
        {
            await _adminCartaoService.AddAsync(adminCartao);
            return CreatedAtAction(nameof(GetById), new { id = adminCartao.Id }, adminCartao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de administradora de cartão.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar administradora de cartão.", error = ex.Message });
        }
    }

    [HttpPut("alterar-administradora-de-cartao/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, AdminCartao adminCartao)
    {
        try
        {
            if (id != adminCartao.Id) return BadRequest();
            await _adminCartaoService.UpdateAsync(adminCartao);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar administradora de cartão.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-administradora-de-cartao/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _adminCartaoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar administração de cartão.", error = ex.Message });
        }
    }

    [HttpGet("credenciadoras-de-cartão")]
    public async Task<IActionResult> GetAllCredenciadorasCartao()
    {
        try
        {
            var credenciadorasCartao = await _credenciadoraCartaoService.GetAllAsync();
            return Ok(credenciadorasCartao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os credenciadores de cartão.", error = ex.Message });
        }
    }

    [HttpGet("buscar-credenciadora-de-cartao-por-id/{id:guid}")]
    public async Task<IActionResult> GetCredenciadoraCartaoById(Guid id)
    {
        try
        {
            var credenciadoraCartao = await _credenciadoraCartaoService.GetByIdAsync(id);
            if (credenciadoraCartao == null) return NotFound(new { message = "Credenciadora de Cartão não encontrado." });
            return Ok(credenciadoraCartao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar credenciadora de cartão por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-credenciadora-de-cartao")]
    public async Task<IActionResult> Create(CredenciadoraCartao credenciadoraCartao)
    {
        try
        {
            await _credenciadoraCartaoService.AddAsync(credenciadoraCartao);
            return CreatedAtAction(nameof(GetById), new { id = credenciadoraCartao.Id }, credenciadoraCartao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastro de credenciadora de cartão.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar credenciadora de cartão.", error = ex.Message });
        }
    }

    [HttpPut("alterar-credenciadora-de-cartao/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, CredenciadoraCartao credenciadoraCartao)
    {
        try
        {
            if (id != credenciadoraCartao.Id) return BadRequest();
            await _credenciadoraCartaoService.UpdateAsync(credenciadoraCartao);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar credenciadora de cartão.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-credenciadora-cartao/{id:guid}")]
    public async Task<IActionResult> DeleteCredenciadoraCartao(Guid id)
    {
        try
        {
            await _credenciadoraCartaoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar credenciadora de cartão.", error = ex.Message });
        }
    }
}
