using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Entities.Pedidos;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Pedidos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Pedido)]
[Route("api/v{version:apiVersion}/[controller]")]
public class MotivosController : ControllerBase
{
    private readonly IMotivoCancelamentoService _motivoCancelamentoService;
    private readonly IMotivoDescontoService _motivoDescontoService;
    private readonly IMotivoDevolucaoService _motivoDevolucaoService;

    public MotivosController(IMotivoCancelamentoService motivoCancelamentoService, IMotivoDescontoService motivoDescontoService, IMotivoDevolucaoService motivoDevolucaoService)
    {
        _motivoCancelamentoService = motivoCancelamentoService;
        _motivoDescontoService = motivoDescontoService;
        _motivoDevolucaoService = motivoDevolucaoService;
    }

    [HttpGet("motivos-para-cancelamento")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var motivosCancelamento = await _motivoCancelamentoService.GetAllAsync();
            return Ok(motivosCancelamento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os motivos para cancelamento.", error = ex.Message });
        }
    }

    [HttpGet("buscar-motivo-para-cancelamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var motivoCancelamento = await _motivoCancelamentoService.GetByIdAsync(id);
            if (motivoCancelamento == null) return NotFound(new { message = "Motivo para cancelamento não encontrado." });
            return Ok(motivoCancelamento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar motivo para cancelamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-motivo-para-cancelamento")]
    public async Task<IActionResult> Create(MotivoCancelamento motivoCancelamento)
    {
        try
        {
            await _motivoCancelamentoService.AddAsync(motivoCancelamento);
            return CreatedAtAction(nameof(GetById), new { id = motivoCancelamento.Id }, motivoCancelamento);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar motivo para cancelamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar motivo para cancelamento.", error = ex.Message });
        }
    }

    [HttpPut("alterar-motivo-para-cancelamento/{id:guid}")]
    public async Task<IActionResult> Update(Guid id, MotivoCancelamento motivoCancelamento)
    {
        try
        {
            if (id != motivoCancelamento.Id) return BadRequest();
            await _motivoCancelamentoService.UpdateAsync(motivoCancelamento);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar motivo para cancelamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-motivo-para-cancelamento/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _motivoCancelamentoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar motivo para cancelamento.", error = ex.Message });
        }
    }

    [HttpGet("motivos-para-desconto")]
    public async Task<IActionResult> GetAllMotivosDesconto()
    {
        try
        {
            var motivosDesconto = await _motivoDescontoService.GetAllAsync();
            return Ok(motivosDesconto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os motivos para desconto.", error = ex.Message });
        }
    }

    [HttpGet("buscar-motivo-para-desconto-por-id/{id:guid}")]
    public async Task<IActionResult> GetMotivoDescontoById(Guid id)
    {
        try
        {
            var motivoDesconto = await _motivoDescontoService.GetByIdAsync(id);
            if (motivoDesconto == null) return NotFound(new { message = "Motivo para desconto não encontrado." });
            return Ok(motivoDesconto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar motivo para desconto por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-motivo-para-desconto")]
    public async Task<IActionResult> CreateMotivoDesconto(MotivoDesconto motivoDesconto)
    {
        try
        {
            await _motivoDescontoService.AddAsync(motivoDesconto);
            return CreatedAtAction(nameof(GetById), new { id = motivoDesconto.Id }, motivoDesconto);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar motivo para desconto.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar motivo para desconto.", error = ex.Message });
        }
    }

    [HttpPut("alterar-motivo-para-desconto/{id:guid}")]
    public async Task<IActionResult> UpdateMotivoDesconto(Guid id, MotivoDesconto motivoDesconto)
    {
        try
        {
            if (id != motivoDesconto.Id) return BadRequest();
            await _motivoDescontoService.UpdateAsync(motivoDesconto);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar motivo para desconto.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-motivo-para-desconto/{id:guid}")]
    public async Task<IActionResult> DeleteMotivoDesconto(Guid id)
    {
        try
        {
            await _motivoDescontoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar motivo para desconto.", error = ex.Message });
        }
    }

    [HttpGet("motivos-para-devolucao")]
    public async Task<IActionResult> GetAllMotivosDevolucao()
    {
        try
        {
            var motivosDevolucao = await _motivoDevolucaoService.GetAllAsync();
            return Ok(motivosDevolucao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os motivos para devolução.", error = ex.Message });
        }
    }

    [HttpGet("buscar-motivo-para-devolucao-por-id/{id:guid}")]
    public async Task<IActionResult> GetMotivoDevolucaoById(Guid id)
    {
        try
        {
            var motivoDevolucao = await _motivoDevolucaoService.GetByIdAsync(id);
            if (motivoDevolucao == null) return NotFound(new { message = "Motivo para devolução não encontrado." });
            return Ok(motivoDevolucao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar motivo para devolução por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-motivo-para-devolucao")]
    public async Task<IActionResult> CreateMotivoDevolucao(MotivoDevolucao motivoDevolucao)
    {
        try
        {
            await _motivoDevolucaoService.AddAsync(motivoDevolucao);
            return CreatedAtAction(nameof(GetById), new { id = motivoDevolucao.Id }, motivoDevolucao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar motivo para devolução.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar motivo para devolução.", error = ex.Message });
        }
    }

    [HttpPut("alterar-motivo-para-devolucao/{id:guid}")]
    public async Task<IActionResult> UpdateMotivoDevolucao(Guid id, MotivoDevolucao motivoDevolucao)
    {
        try
        {
            if (id != motivoDevolucao.Id) return BadRequest();
            await _motivoDevolucaoService.UpdateAsync(motivoDevolucao);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar motivo para devolução.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-motivo-para-devolucao/{id:guid}")]
    public async Task<IActionResult> DeleteMotivoDevolucao(Guid id)
    {
        try
        {
            await _motivoDevolucaoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar motivo para devolução.", error = ex.Message });
        }
    }
}
