using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Produtos;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Produtos;

[ApiController]
[ApiVersion("1.0"), ApiGroup(ApiGroupNames.Produto)]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _produtoService;
    private readonly IUnidadeMedidaService _unidadeMedidaService;
    private readonly IProdutoLookComposicaoService _produtoLookComposicaoService;
    private readonly IProdutoKitService _produtoKitService;
    private readonly IProdutoCorBasicaService _produtoCorBasicaService;
    private readonly IProdutoCodigoBarraService _produtoCodigoBarraService;
    private readonly IProdutoCatalogoService _produtoCatalogoService;
    private readonly IArtigoBrindeService _artigoBrindeService;
    private readonly IKitService _kitService;

    public ProdutoController (IProdutoService produtoService, IUnidadeMedidaService unidadeMedidaService, IProdutoLookComposicaoService produtoLookComposicaoService, IProdutoKitService produtoKitService, IProdutoCorBasicaService produtoCorBasicaService, IProdutoCodigoBarraService produtoCodigoBarraService, IProdutoCatalogoService produtoCatalogoService, IArtigoBrindeService artigoBrindeService, IKitService kitService)
    {
        _produtoService = produtoService;
        _unidadeMedidaService = unidadeMedidaService;
        _produtoLookComposicaoService = produtoLookComposicaoService;
        _produtoKitService = produtoKitService;
        _produtoCorBasicaService = produtoCorBasicaService;
        _produtoCodigoBarraService = produtoCodigoBarraService;
        _produtoCatalogoService = produtoCatalogoService;
        _artigoBrindeService = artigoBrindeService;
        _kitService = kitService;
    }

    [HttpGet("produtos")]
    public async Task<IActionResult> GetAllProdutos()
    {
        try
        {
            var produtos = await _produtoService.GetAllAsync();
            return Ok(produtos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os produtos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-produto-por-id/{id:guid}")]
    public async Task<IActionResult> GetProdutoById(Guid id)
    {
        try
        {
            var produto = await _produtoService.GetByIdAsync(id);
            if (produto == null) return NotFound(new { message = "Produto não encontrado." });
            return Ok(produto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar produto por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-produto")]
    public async Task<IActionResult> CreateProduto(Produto produto)
    {
        try
        {
            await _produtoService.AddAsync(produto);
            return CreatedAtAction(nameof(GetProdutoById), new { id = produto.Id }, produto);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar produto.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar produto.", error = ex.Message });
        }
    }

    [HttpPut("alterar-produto/{id:guid}")]
    public async Task<IActionResult> UpdateProduto(Guid id, Produto produto)
    {
        try
        {
            if (id != produto.Id) return BadRequest();
            await _produtoService.UpdateAsync(produto);
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
            await _produtoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar produto.", error = ex.Message });
        }
    }

    [HttpGet("unidades-de-medida")]
    public async Task<IActionResult> GetAllUnidadesMedida()
    {
        try
        {
            var unidadesMedida = await _unidadeMedidaService.GetAllAsync();
            return Ok(unidadesMedida);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos as unidades de medida.", error = ex.Message });
        }
    }

    [HttpGet("buscar-unidade-de-medida-por-id/{id:guid}")]
    public async Task<IActionResult> GetUnidadeMedidaById(Guid id)
    {
        try
        {
            var unidadeMedida = await _unidadeMedidaService.GetByIdAsync(id);
            if (unidadeMedida == null) return NotFound(new { message = "Unidade de Medida não encontrado." });
            return Ok(unidadeMedida);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar unidade de medida por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-unidade-medida")]
    public async Task<IActionResult> CreateUnidadeMedida(UnidadeMedida unidadeMedida)
    {
        try
        {
            await _unidadeMedidaService.AddAsync(unidadeMedida);
            return CreatedAtAction(nameof(GetUnidadeMedidaById), new { id = unidadeMedida.Id }, unidadeMedida);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar unidade de medida.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar unidade de medida.", error = ex.Message });
        }
    }

    [HttpPut("alterar-unidade-medida/{id:guid}")]
    public async Task<IActionResult> UpdateUnidadeMedida(Guid id, UnidadeMedida unidadeMedida)
    {
        try
        {
            if (id != unidadeMedida.Id) return BadRequest();
            await _unidadeMedidaService.UpdateAsync(unidadeMedida);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar unidade medida.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-unidade-medida/{id:guid}")]
    public async Task<IActionResult> DeleteUnidadeMedida(Guid id)
    {
        try
        {
            await _unidadeMedidaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar unidade medida.", error = ex.Message });
        }
    }

    [HttpGet("looks")]
    public async Task<IActionResult> GetAllLooks()
    {
        try
        {
            var looks = await _produtoLookComposicaoService.GetAllAsync();
            return Ok(looks);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os looks.", error = ex.Message });
        }
    }

    [HttpGet("buscar-look-por-id/{id:guid}")]
    public async Task<IActionResult> GetLookById(Guid id)
    {
        try
        {
            var look = await _produtoLookComposicaoService.GetByIdAsync(id);
            if (look == null) return NotFound(new { message = "Look não encontrado." });
            return Ok(look);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar look por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-look")]
    public async Task<IActionResult> CreateDesconto(ProdutoLookComposicao look)
    {
        try
        {
            await _produtoLookComposicaoService.AddAsync(look);
            return CreatedAtAction(nameof(GetLookById), new { id = look.Id }, look);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar look.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar look.", error = ex.Message });
        }
    }

    [HttpPut("alterar-look/{id:guid}")]
    public async Task<IActionResult> UpdateLook(Guid id, ProdutoLookComposicao look)
    {
        try
        {
            if (id != look.Id) return BadRequest();
            await _produtoLookComposicaoService.UpdateAsync(look);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar look.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-look/{id:guid}")]
    public async Task<IActionResult> DeleteLook(Guid id)
    {
        try
        {
            await _produtoLookComposicaoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar look.", error = ex.Message });
        }
    }

    [HttpGet("produtos-kit")]
    public async Task<IActionResult> GetAllProdutosKit()
    {
        try
        {
            var produtosKit = await _produtoKitService.GetAllAsync();
            return Ok(produtosKit);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os produtos que fazem parte de kits.", error = ex.Message });
        }
    }

    [HttpGet("buscar-produto-kit-por-id/{id:guid}")]
    public async Task<IActionResult> GetProdutoKitById(Guid id)
    {
        try
        {
            var produtoKit = await _produtoKitService.GetByIdAsync(id);
            if (produtoKit == null) return NotFound(new { message = "Produto de Kit não encontrado." });
            return Ok(produtoKit);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar produto que faz de Kit por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-produto-de-kit")]
    public async Task<IActionResult> CreateProdutoKit(ProdutoKit produtoKit)
    {
        try
        {
            await _produtoKitService.AddAsync(produtoKit);
            return CreatedAtAction(nameof(GetProdutoKitById), new { id = produtoKit.Id }, produtoKit);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar produto de kit.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar produto de kit.", error = ex.Message });
        }
    }

    [HttpPut("alterar-produto-kit/{id:guid}")]
    public async Task<IActionResult> UpdateProdutoKit(Guid id, ProdutoKit produtoKit)
    {
        try
        {
            if (id != produtoKit.Id) return BadRequest();
            await _produtoKitService.UpdateAsync(produtoKit);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar produto de kit.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-produto-kit/{id:guid}")]
    public async Task<IActionResult> DeleteProdutoKit(Guid id)
    {
        try
        {
            await _produtoKitService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar produto kit.", error = ex.Message });
        }
    }

    [HttpGet("cores")]
    public async Task<IActionResult> GetAllCores()
    {
        try
        {
            var cores = await _produtoCorBasicaService.GetAllAsync();
            return Ok(cores);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todas as cores.", error = ex.Message });
        }
    }

    [HttpGet("buscar-cor-por-id/{id:guid}")]
    public async Task<IActionResult> GetCorById(Guid id)
    {
        try
        {
            var cor = await _produtoCorBasicaService.GetByIdAsync(id);
            if (cor == null) return NotFound(new { message = "Cor não encontrada." });
            return Ok(cor);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar cor por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-cor")]
    public async Task<IActionResult> CreateCor(ProdutoCorBasica cor)
    {
        try
        {
            await _produtoCorBasicaService.AddAsync(cor);
            return CreatedAtAction(nameof(GetCorById), new { id = cor.Id }, cor);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar cor.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar cor.", error = ex.Message });
        }
    }

    [HttpPut("alterar-cor/{id:guid}")]
    public async Task<IActionResult> UpdateCor(Guid id, ProdutoCorBasica cor)
    {
        try
        {
            if (id != cor.Id) return BadRequest();
            await _produtoCorBasicaService.UpdateAsync(cor);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar cor.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-cor/{id:guid}")]
    public async Task<IActionResult> DeleteCor(Guid id)
    {
        try
        {
            await _produtoCorBasicaService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar cor.", error = ex.Message });
        }
    }

    [HttpGet("codigos-de-barra")]
    public async Task<IActionResult> GetAllCodigosDeBarra()
    {
        try
        {
            var codigosBarra = await _produtoCodigoBarraService.GetAllAsync();
            return Ok(codigosBarra);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os códigos de barra.", error = ex.Message });
        }
    }

    [HttpGet("buscar-codigo-barra-por-id/{id:guid}")]
    public async Task<IActionResult> GetCodigoBarraById(Guid id)
    {
        try
        {
            var codigoBarra = await _produtoCodigoBarraService.GetByIdAsync(id);
            if (codigoBarra == null) return NotFound(new { message = "Código de Barra não encontrado." });
            return Ok(codigoBarra);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar código de barra por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-codigo-barra")]
    public async Task<IActionResult> CreateCodigoBarra(ProdutoCodigoBarra codigoBarra)
    {
        try
        {
            await _produtoCodigoBarraService.AddAsync(codigoBarra);
            return CreatedAtAction(nameof(GetCodigoBarraById), new { id = codigoBarra.Id }, codigoBarra);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar código de barra.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar código de barra.", error = ex.Message });
        }
    }

    [HttpPut("alterar-codigo-barra/{id:guid}")]
    public async Task<IActionResult> UpdateCodigoBarra(Guid id, ProdutoCodigoBarra produtoCodigoBarra)
    {
        try
        {
            if (id != produtoCodigoBarra.Id) return BadRequest();
            await _produtoCodigoBarraService.UpdateAsync(produtoCodigoBarra);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar código de barra.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-codigo-barra/{id:guid}")]
    public async Task<IActionResult> DeleteCodigoBarra(Guid id)
    {
        try
        {
            await _produtoCodigoBarraService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar código de barra.", error = ex.Message });
        }
    }

    [HttpGet("catalogos")]
    public async Task<IActionResult> GetAllCatalogos()
    {
        try
        {
            var catalogos = await _produtoCatalogoService.GetAllAsync();
            return Ok(catalogos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os catalogos.", error = ex.Message });
        }
    }

    [HttpGet("buscar-catalogo-por-id/{id:guid}")]
    public async Task<IActionResult> GetCatalogoById(Guid id)
    {
        try
        {
            var catalogo = await _produtoCatalogoService.GetByIdAsync(id);
            if (catalogo == null) return NotFound(new { message = "Catálogo não encontrado." });
            return Ok(catalogo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar catálogo por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-catalogo")]
    public async Task<IActionResult> CreateCatalogo(ProdutoCatalogo catalogo)
    {
        try
        {
            await _produtoCatalogoService.AddAsync(catalogo);
            return CreatedAtAction(nameof(GetCatalogoById), new { id = catalogo.Id }, catalogo);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar catálogo.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar catálogo.", error = ex.Message });
        }
    }

    [HttpPut("alterar-catalogo/{id:guid}")]
    public async Task<IActionResult> UpdateCatalogo(Guid id, ProdutoCatalogo catalogo)
    {
        try
        {
            if (id != catalogo.Id) return BadRequest();
            await _produtoCatalogoService.UpdateAsync(catalogo);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar catálogo.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-catalogo/{id:guid}")]
    public async Task<IActionResult> DeleteCatalogo(Guid id)
    {
        try
        {
            await _produtoCatalogoService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar catálogo.", error = ex.Message });
        }
    }

    [HttpGet("brindes")]
    public async Task<IActionResult> GetAllBrindes()
    {
        try
        {
            var brindes = await _artigoBrindeService.GetAllAsync();
            return Ok(brindes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os brindes.", error = ex.Message });
        }
    }

    [HttpGet("buscar-brinde-por-id/{id:guid}")]
    public async Task<IActionResult> GetBrindeById(Guid id)
    {
        try
        {
            var brinde = await _artigoBrindeService.GetByIdAsync(id);
            if (brinde == null) return NotFound(new { message = "Brinde não encontrado." });
            return Ok(brinde);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar brinde por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-brinde")]
    public async Task<IActionResult> CreateBrinde(ArtigoBrinde brinde)
    {
        try
        {
            await _artigoBrindeService.AddAsync(brinde);
            return CreatedAtAction(nameof(GetBrindeById), new { id = brinde.Id }, brinde);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar brinde.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar brinde.", error = ex.Message });
        }
    }

    [HttpPut("alterar-brinde/{id:guid}")]
    public async Task<IActionResult> UpdateBrinde(Guid id, ArtigoBrinde brinde)
    {
        try
        {
            if (id != brinde.Id) return BadRequest();
            await _artigoBrindeService.UpdateAsync(brinde);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar brinde.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-brinde/{id:guid}")]
    public async Task<IActionResult> DeleteBrinde(Guid id)
    {
        try
        {
            await _artigoBrindeService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar brinde.", error = ex.Message });
        }
    }

    [HttpGet("kits")]
    public async Task<IActionResult> GetAllKits()
    {
        try
        {
            var kits = await _kitService.GetAllAsync();
            return Ok(kits);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao obter todos os kits.", error = ex.Message });
        }
    }

    [HttpGet("buscar-kit-por-id/{id:guid}")]
    public async Task<IActionResult> GetKitById(Guid id)
    {
        try
        {
            var kit = await _kitService.GetByIdAsync(id);
            if (kit == null) return NotFound(new { message = "Kit não encontrado." });
            return Ok(kit);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao buscar kit por ID.", error = ex.Message });
        }
    }

    [HttpPost("cadastrar-kit")]
    public async Task<IActionResult> CreateKit(Kit kit)
    {
        try
        {
            await _kitService.AddAsync(kit);
            return CreatedAtAction(nameof(GetKitById), new { id = kit.Id }, kit);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(new { message = "Dados incompletos para cadastrar kit.", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao cadastrar kit.", error = ex.Message });
        }
    }

    [HttpPut("alterar-kit/{id:guid}")]
    public async Task<IActionResult> UpdateKit(Guid id, Kit kit)
    {
        try
        {
            if (id != kit.Id) return BadRequest();
            await _kitService.UpdateAsync(kit);
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
            return StatusCode(500, new { message = "Erro interno ao atualizar kit.", error = ex.Message });
        }
    }

    [HttpDelete("deletar-kit/{id:guid}")]
    public async Task<IActionResult> DeleteKit(Guid id)
    {
        try
        {
            await _kitService.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno ao deletar kit.", error = ex.Message });
        }
    }
}
