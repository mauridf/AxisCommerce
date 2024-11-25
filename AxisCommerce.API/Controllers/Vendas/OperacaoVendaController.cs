using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Vendas;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Venda)]
[Route("api/v{version:apiVersion}/[controller]")]
public class OperacaoVendaController : ControllerBase
{
    private readonly IOperacaoVendaService _operacaoVendaService;
    private readonly IOperacaoVendaCondicaoPgtoService _operacaoVendaCondicaoPagtoService;
    private readonly IOperacaoVendaTipoClienteService _operacaoVendaTipoCliente;
    private readonly ITipoOperacaoVendaService _tipoOperacaoVendaService;

    public OperacaoVendaController(IOperacaoVendaService operacaoVendaService, IOperacaoVendaCondicaoPgtoService operacaoVendaCondicaoPagtoService, IOperacaoVendaTipoClienteService operacaoVendaTipoCliente, ITipoOperacaoVendaService tipoOperacaoVendaService)
    {
        _operacaoVendaService = operacaoVendaService;
        _operacaoVendaCondicaoPagtoService = operacaoVendaCondicaoPagtoService;
        _operacaoVendaTipoCliente = operacaoVendaTipoCliente;
        _tipoOperacaoVendaService = tipoOperacaoVendaService;
    }

    [HttpGet("operacoes-de-venda")]
    public async Task<IActionResult> GetAllOperacoesVenda()
    {
        try
        {
            var operacoesVenda = await _operacaoVendaService.GetAllAsync();
            return Ok(operacoesVenda);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as operações de venda.", error = ex.Message });
        }
    }

    [HttpGet("buscar-operacao-de-venda-por-id/{id:guid}")]
    public async Task<IActionResult> GetOperacaoVendaById(Guid id)
    {
        try
        {
            var operacaoVenda = await _operacaoVendaService.GetByIdAsync(id);
            if (operacaoVenda == null) return NotFound(new { message = "Operação de Venda não encontrado." });
            return Ok(operacaoVenda);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar operação de venda por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-operacao-de-venda")]
    public async Task<IActionResult> CreateOperacaoVenda(OperacaoVenda operacaoVenda)
    {
        try
        {
            await _operacaoVendaService.AddAsync(operacaoVenda);
            return CreatedAtAction(nameof(GetOperacaoVendaById), new { id = operacaoVenda.Id }, operacaoVenda);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar operação de venda.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar operação de venda.", error = ex.Message });
        }
    }

    [HttpPut("alterar-operacao-de-venda/{id:guid}")]
    public async Task<IActionResult> UpdateOperacaoVenda(Guid id, OperacaoVenda operacaoVenda)
    {
        try
        {
            if (id != operacaoVenda.Id) return BadRequest();
            await _operacaoVendaService.UpdateAsync(operacaoVenda);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar desconto.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-operacao-de-venda/{id:guid}")]
    public async Task<IActionResult> DeleteOperacaoVenda(Guid id)
    {
        try
        {
            await _operacaoVendaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar operação de venda.", error = ex.Message });
        }
    }

    [HttpGet("condicoes-pgto")]
    public async Task<IActionResult> GetAllCondicoesPagto()
    {
        try
        {
            var condicoesPagto = await _operacaoVendaCondicaoPagtoService.GetAllAsync();
            return Ok(condicoesPagto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as condições de pagamento.", error = ex.Message });
        }
    }

    [HttpGet("buscar-condicao-de-pagamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetCondicaoPagtoById(Guid id)
    {
        try
        {
            var condicaoPagto = await _operacaoVendaCondicaoPagtoService.GetByIdAsync(id);
            if (condicaoPagto == null) return NotFound(new { message = "Condição de Pagamento não encontrado." });
            return Ok(condicaoPagto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar condição de pagamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-condicao-de-pagamento")]
    public async Task<IActionResult> CreateDesconto(OperacaoVendaCondicaoPgto condicaoPagto)
    {
        try
        {
            await _operacaoVendaCondicaoPagtoService.AddAsync(condicaoPagto);
            return CreatedAtAction(nameof(GetCondicaoPagtoById), new { id = condicaoPagto.Id }, condicaoPagto);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar condição de pagamento.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar condição de pagamento.", error = ex.Message });
        }
    }

    [HttpPut("alterar-condicao-pagamento/{id:guid}")]
    public async Task<IActionResult> UpdateCondicaoPagto(Guid id, OperacaoVendaCondicaoPgto condicaoPagto)
    {
        try
        {
            if (id != condicaoPagto.Id) return BadRequest();
            await _operacaoVendaCondicaoPagtoService.UpdateAsync(condicaoPagto);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar condição de pagamento.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-conicao-de-pagamento/{id:guid}")]
    public async Task<IActionResult> DeleteCondicaoPagto(Guid id)
    {
        try
        {
            await _operacaoVendaCondicaoPagtoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar condição de pagamento.", error = ex.Message });
        }
    }

    [HttpGet("tipos-de-clientes")]
    public async Task<IActionResult> GetAllTipoCliente()
    {
        try
        {
            var tiposCliente = await _operacaoVendaTipoCliente.GetAllAsync();
            return Ok(tiposCliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de clientes.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tipo-cliente-por-id/{id:guid}")]
    public async Task<IActionResult> GetTipoClienteById(Guid id)
    {
        try
        {
            var tipoCliente = await _operacaoVendaTipoCliente.GetByIdAsync(id);
            if (tipoCliente == null) return NotFound(new { message = "Tipo de Cliente não encontrado." });
            return Ok(tipoCliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo de cliente por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tipo-cliente")]
    public async Task<IActionResult> CreateTipoCliente(OperacaoVendaTipoCliente tipoCliente)
    {
        try
        {
            await _operacaoVendaTipoCliente.AddAsync(tipoCliente);
            return CreatedAtAction(nameof(GetTipoClienteById), new { id = tipoCliente.Id }, tipoCliente);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar tipo de cliente.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tipo de cliente.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tipo-de-cliente/{id:guid}")]
    public async Task<IActionResult> UpdateDesconto(Guid id, OperacaoVendaTipoCliente tipoCliente)
    {
        try
        {
            if (id != tipoCliente.Id) return BadRequest();
            await _operacaoVendaTipoCliente.UpdateAsync(tipoCliente);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar tipo de cliente.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo-de-cliente/{id:guid}")]
    public async Task<IActionResult> DeleteTipoCliente(Guid id)
    {
        try
        {
            await _operacaoVendaTipoCliente.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo de cliente.", error = ex.Message });
        }
    }

    [HttpGet("tipos-de-operacao-de-venda")]
    public async Task<IActionResult> GetAllTipoOperacoesVenda()
    {
        try
        {
            var tipoOperacoesVenda = await _tipoOperacaoVendaService.GetAllAsync();
            return Ok(tipoOperacoesVenda);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de operação de venda.", error = ex.Message });
        }
    }

    [HttpGet("buscar-operacao-de-venda-por-id/{id:guid}")]
    public async Task<IActionResult> GetTipoOperacaoVendaById(Guid id)
    {
        try
        {
            var operacaoVenda = await _tipoOperacaoVendaService.GetByIdAsync(id);
            if (operacaoVenda == null) return NotFound(new { message = "Tipo Operação de Venda não encontrado." });
            return Ok(operacaoVenda);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo de operação de venda por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tipo-operacao-venda")]
    public async Task<IActionResult> CreateTipoOperacaoVenda(TipoOperacaoVenda tipoOperacaoVenda)
    {
        try
        {
            await _tipoOperacaoVendaService.AddAsync(tipoOperacaoVenda);
            return CreatedAtAction(nameof(GetTipoOperacaoVendaById), new { id = tipoOperacaoVenda.Id }, tipoOperacaoVenda);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar tipo de operacão de venda.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tipo de operação de venda.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tipo-operacao-venda/{id:guid}")]
    public async Task<IActionResult> UpdateTipoOperacaoVenda(Guid id, TipoOperacaoVenda tipoOperacaoVenda)
    {
        try
        {
            if (id != tipoOperacaoVenda.Id) return BadRequest();
            await _tipoOperacaoVendaService.UpdateAsync(tipoOperacaoVenda);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar tipo operação de venda.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo-operacao-venda/{id:guid}")]
    public async Task<IActionResult> DeleteTipoOperacaoVenda(Guid id)
    {
        try
        {
            await _tipoOperacaoVendaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo operaçao de venda.", error = ex.Message });
        }
    }
}
