using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Application.Services.Pedidos;
using AxisCommerce.Domain.Entities.Pedidos;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Pedidos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Pedido)]
[Route("api/v{version:apiVersion}/[controller]")]
public class PedidosController : ControllerBase
{ 
    private readonly IPedidoDescontoService _descontoService;
    private readonly IPedidoEntregaService _entregaService;
    private readonly IPedidoItemService _itemService;
    private readonly IPedidoPagtoService _pagtoService;
    private readonly IPedidoPromocaoService _promocaoService;
    private readonly IPedidoService _pedidoService;
    private readonly IPedidoVendedorService _vendedorService;
    private readonly ITipoPedidoService _tipoPeditoService;

    public PedidosController(IPedidoDescontoService descontoService, IPedidoEntregaService entregaService, IPedidoItemService itemService, IPedidoPagtoService pagtoService, IPedidoPromocaoService promocaoService, IPedidoService pedidoService, IPedidoVendedorService vendedorService, ITipoPedidoService pedidoVendedorService)
    {
        _descontoService = descontoService;
        _entregaService = entregaService;
        _itemService = itemService;
        _pagtoService = pagtoService;
        _promocaoService = promocaoService;
        _pedidoService = pedidoService;
        _vendedorService = vendedorService;
        _tipoPeditoService = pedidoVendedorService;
    }

    [HttpGet("descontos")]
    public async Task<IActionResult> GetAllDescontos()
    {
        try
        {
            var descontos = await _descontoService.GetAllAsync();
            return Ok(descontos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os descontos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-desconto-por-id/{id:guid}")]
    public async Task<IActionResult> GetDescontoById(Guid id)
    {
        try
        {
            var desconto = await _descontoService.GetByIdAsync(id);
            if (desconto == null) return NotFound(new { message = "Desconto não encontrado." });
            return Ok(desconto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar desconto por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-desconto")]
    public async Task<IActionResult> CreateDesconto(PedidoDesconto desconto)
    {
        try
        {
            await _descontoService.AddAsync(desconto);
            return CreatedAtAction(nameof(GetDescontoById), new { id = desconto.Id }, desconto);
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

    [HttpPut("alterar-desconto/{id:guid}")]
    public async Task<IActionResult> UpdateDesconto(Guid id, PedidoDesconto desconto)
    {
        try
        {
            if (id != desconto.Id) return BadRequest();
            await _descontoService.UpdateAsync(desconto);
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

    [HttpDelete("deletar-desconto/{id:guid}")]
    public async Task<IActionResult> DeleteDesconto(Guid id)
    {
        try
        {
            await _descontoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar desconto.", error = ex.Message });
        }
    }

    [HttpGet("entrega")]
    public async Task<IActionResult> GetAllEntregas()
    {
        try
        {
            var entregas = await _entregaService.GetAllAsync();
            return Ok(entregas);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as entregas.", error = ex.Message });
        }
    }

    [HttpGet("buscar-entrega-por-id/{id:guid}")]
    public async Task<IActionResult> GetEntregaById(Guid id)
    {
        try
        {
            var entrega = await _entregaService.GetByIdAsync(id);
            if (entrega == null) return NotFound(new { message = "Entrega não encontrada." });
            return Ok(entrega);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar entrega por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-entrega")]
    public async Task<IActionResult> CreateEntrega(PedidoEntrega entrega)
    {
        try
        {
            await _entregaService.AddAsync(entrega);
            return CreatedAtAction(nameof(GetEntregaById), new { id = entrega.Id }, entrega);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar entrega.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar entrega.", error = ex.Message });
        }
    }

    [HttpPut("alterar-entrega/{id:guid}")]
    public async Task<IActionResult> UpdateEntrega(Guid id, PedidoEntrega entrega)
    {
        try
        {
            if (id != entrega.Id) return BadRequest();
            await _entregaService.UpdateAsync(entrega);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar entrega.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-entrega/{id:guid}")]
    public async Task<IActionResult> DeleteEntrega(Guid id)
    {
        try
        {
            await _entregaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar entrega.", error = ex.Message });
        }
    }

    [HttpGet("itens")]
    public async Task<IActionResult> GetAllItens()
    {
        try
        {
            var itens = await _itemService.GetAllAsync();
            return Ok(itens);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os itens do pedido.", error = ex.Message });
        }
    }

    [HttpGet("buscar-item-por-id/{id:guid}")]
    public async Task<IActionResult> GetItemById(Guid id)
    {
        try
        {
            var item = await _itemService.GetByIdAsync(id);
            if (item == null) return NotFound(new { message = "Item não encontrado." });
            return Ok(item);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar item por ID.", error = ex.Message });
        }
    }

    [HttpPost("adicionar-item-ao-pedido")]
    public async Task<IActionResult> AdicionarItemPedido(PedidoItem item)
    {
        try
        {
            await _itemService.AddAsync(item);
            return CreatedAtAction(nameof(GetItemById), new { id = item.Id }, item);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para item ao pedido.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao item ao pedido.", error = ex.Message });
        }
    }

    [HttpPut("alterar-item-pedido/{id:guid}")]
    public async Task<IActionResult> UpdateItemPedido(Guid id, PedidoItem item)
    {
        try
        {
            if (id != item.Id) return BadRequest();
            await _itemService.UpdateAsync(item);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar item do pedido.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-item-do-pedido/{id:guid}")]
    public async Task<IActionResult> DeleteItemPedido(Guid id)
    {
        try
        {
            await _itemService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar item do pedido.", error = ex.Message });
        }
    }

    [HttpGet("pagamento")]
    public async Task<IActionResult> GetAllPagamentos()
    {
        try
        {
            var pagamentos = await _pagtoService.GetAllAsync();
            return Ok(pagamentos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os pagamentos dos pedidos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-pagamento-por-id/{id:guid}")]
    public async Task<IActionResult> GetPagamentoById(Guid id)
    {
        try
        {
            var pagamento = await _pagtoService.GetByIdAsync(id);
            if (pagamento == null) return NotFound(new { message = "Pagamento não encontrado." });
            return Ok(pagamento);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar pagamento por ID.", error = ex.Message });
        }
    }

    [HttpPost("efetuar-pagamento-pedido")]
    public async Task<IActionResult> EfetuarPagamentoPedido(PedidoPagto pedidoPagto)
    {
        try
        {
            await _pagtoService.AddAsync(pedidoPagto);
            return CreatedAtAction(nameof(GetPagamentoById), new { id = pedidoPagto.Id }, pedidoPagto);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para efetuar pagamento do pedido.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao efetuar pagamento do pedido.", error = ex.Message });
        }
    }

    [HttpPut("alterar-pagamento-pedido/{id:guid}")]
    public async Task<IActionResult> UpdatePagamento(Guid id, PedidoPagto pedidoPagto)
    {
        try
        {
            if (id != pedidoPagto.Id) return BadRequest();
            await _pagtoService.UpdateAsync(pedidoPagto);
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
            return StatusCode(500, new { message = "Erro interno ao alterar pagamento do pedido.", error = ex.Message });
        }
    }

    [HttpDelete("cancelar-pagamento/{id:guid}")]
    public async Task<IActionResult> DeletePagamento(Guid id)
    {
        try
        {
            await _pagtoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cancelar pagamento.", error = ex.Message });
        }
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
            return StatusCode(500, new { message = "Erro interno ao obter todas as promoções efetivadas.", error = ex.Message });
        }
    }

    [HttpGet("buscar-promocao-por-id/{id:guid}")]
    public async Task<IActionResult> GetPromocaoById(Guid id)
    {
        try
        {
            var promocao = await _promocaoService.GetByIdAsync(id);
            if (promocao == null) return NotFound(new { message = "Promoção efetivada não encontrada." });
            return Ok(promocao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar motivo para devolução por ID.", error = ex.Message });
        }
    }

    [HttpPost("efetivar-promocao-pedido")]
    public async Task<IActionResult> EfetivarPromocaoPedido(PedidoPromocao pedidoPromocao)
    {
        try
        {
            await _promocaoService.AddAsync(pedidoPromocao);
            return CreatedAtAction(nameof(GetPromocaoById), new { id = pedidoPromocao.Id }, pedidoPromocao);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para efetivar promoção no pedido.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao efetivar promoção no pedido.", error = ex.Message });
        }
    }

    [HttpPut("alterar-promocao/{id:guid}")]
    public async Task<IActionResult> UpdatePedidoPromocao(Guid id, PedidoPromocao pedidoPromocao)
    {
        try
        {
            if (id != pedidoPromocao.Id) return BadRequest();
            await _promocaoService.UpdateAsync(pedidoPromocao);
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
            return StatusCode(500, new { message = "Erro interno ao alterar promoção.", error = ex.Message });
        }
    }

    [HttpDelete("cancelar-promocao/{id:guid}")]
    public async Task<IActionResult> CancelarPromocao(Guid id)
    {
        try
        {
            await _promocaoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cancelar promoção.", error = ex.Message });
        }
    }

    [HttpGet("pedidos")]
    public async Task<IActionResult> GetAllPedidos()
    {
        try
        {
            var pedidos = await _pedidoService.GetAllAsync();
            return Ok(pedidos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os pedidos.", error = ex.Message });
        }
    }

    [HttpGet("pedido-por-id/{id:guid}")]
    public async Task<IActionResult> GetPedidoById(Guid id)
    {
        try
        {
            var pedido = await _pedidoService.GetByIdAsync(id);
            if (pedido == null) return NotFound(new { message = "Pedido não encontrado." });
            return Ok(pedido);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar pedido por ID.", error = ex.Message });
        }
    }

    [HttpPost("efetuar-pedido")]
    public async Task<IActionResult> EfetuarPedido(Pedido pedido)
    {
        try
        {
            await _pedidoService.AddAsync(pedido);
            return CreatedAtAction(nameof(GetPedidoById), new { id = pedido.Id }, pedido);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para efetuar pedido.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao efetuar pedido.", error = ex.Message });
        }
    }

    [HttpPut("alterar-pedido/{id:guid}")]
    public async Task<IActionResult> UpdatePedido(Guid id, Pedido pedido)
    {
        try
        {
            if (id != pedido.Id) return BadRequest();
            await _pedidoService.UpdateAsync(pedido);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar pedido.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-pedido/{id:guid}")]
    public async Task<IActionResult> CancelarPedido(Guid id)
    {
        try
        {
            await _pedidoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar pedido.", error = ex.Message });
        }
    }

    [HttpGet("pedidos-vendedores")]
    public async Task<IActionResult> GetAllPedidosVendedores()
    {
        try
        {
            var pedidosVendedores = await _vendedorService.GetAllAsync();
            return Ok(pedidosVendedores);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os pedidos com vendedores.", error = ex.Message });
        }
    }

    [HttpGet("buscar-pedido-vendedor-por-id/{id:guid}")]
    public async Task<IActionResult> GetPedidoVendedorById(Guid id)
    {
        try
        {
            var pedidoVendedor = await _vendedorService.GetByIdAsync(id);
            if (pedidoVendedor == null) return NotFound(new { message = "Pedido com Vendedor não encontrado." });
            return Ok(pedidoVendedor);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar pedido com vendedor por ID.", error = ex.Message });
        }
    }

    [HttpPost("atribuir-vendedor-ao-pedido")]
    public async Task<IActionResult> AtribuiVendedor(PedidoVendedor pedidoVendedor)
    {
        try
        {
            await _vendedorService.AddAsync(pedidoVendedor);
            return CreatedAtAction(nameof(GetPedidoVendedorById), new { id = pedidoVendedor.Id }, pedidoVendedor);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para atribuir vendedor ao pedido.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao atribuir vendedor ao pedido.", error = ex.Message });
        }
    }

    [HttpPut("alterar-vendedor-pedido/{id:guid}")]
    public async Task<IActionResult> UpdatePedidoVendedor(Guid id, PedidoVendedor pedidoVendedor)
    {
        try
        {
            if (id != pedidoVendedor.Id) return BadRequest();
            await _vendedorService.UpdateAsync(pedidoVendedor);
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
            return StatusCode(500, new { message = "Erro interno ao alterar vendedor do pedido.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-pedido-vendedor/{id:guid}")]
    public async Task<IActionResult> DeletePedidoVendedor(Guid id)
    {
        try
        {
            await _vendedorService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar/desvincular vendedor do pedido.", error = ex.Message });
        }
    }

    [HttpGet("tipo-pedido")]
    public async Task<IActionResult> GetAllTipoPedido()
    {
        try
        {
            var tipoPedido = await _tipoPeditoService.GetAllAsync();
            return Ok(tipoPedido);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os tipos de pedido.", error = ex.Message });
        }
    }

    [HttpGet("buscar-tipo-pedido-por-id/{id:guid}")]
    public async Task<IActionResult> GetTipoPedidoById(Guid id)
    {
        try
        {
            var tipoPedido = await _tipoPeditoService.GetByIdAsync(id);
            if (tipoPedido == null) return NotFound(new { message = "Tipo Pedido não encontrado." });
            return Ok(tipoPedido);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar tipo pedido por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-tipo-pedido")]
    public async Task<IActionResult> CreateTipoPedido(TipoPedido tipoPedido)
    {
        try
        {
            await _tipoPeditoService.AddAsync(tipoPedido);
            return CreatedAtAction(nameof(GetTipoPedidoById), new { id = tipoPedido.Id }, tipoPedido);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar tipo pedido.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar tipo pedido.", error = ex.Message });
        }
    }

    [HttpPut("alterar-tipo-pedido/{id:guid}")]
    public async Task<IActionResult> UpdateTipoPedido(Guid id, TipoPedido tipoPedido)
    {
        try
        {
            if (id != tipoPedido.Id) return BadRequest();
            await _tipoPeditoService.UpdateAsync(tipoPedido);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar tipo pedido.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-tipo-pedido/{id:guid}")]
    public async Task<IActionResult> DeleteTipoPedido(Guid id)
    {
        try
        {
            await _tipoPeditoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar tipo pedido.", error = ex.Message });
        }
    }
}
