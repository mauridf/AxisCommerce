using AxisCommerce.Application.Interfaces.Caixa;
using AxisCommerce.Application.Interfaces.Clientes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Application.Interfaces.Pedidos;
using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Application.Services.Caixa;
using AxisCommerce.Application.Services.Clientes;
using AxisCommerce.Application.Services.Lojas;
using AxisCommerce.Application.Services.Pagamento;
using AxisCommerce.Application.Services.Pedidos;
using AxisCommerce.Application.Services.Produtos;
using AxisCommerce.Application.Services.Vendas;
using AxisCommerce.Domain.Interfaces.Autenticacao;
using AxisCommerce.Domain.Interfaces.Caixa;
using AxisCommerce.Domain.Interfaces.Clientes;
using AxisCommerce.Domain.Interfaces.Loja;
using AxisCommerce.Domain.Interfaces.Pagamento;
using AxisCommerce.Domain.Interfaces.Pedidos;
using AxisCommerce.Domain.Interfaces.Produtos;
using AxisCommerce.Domain.Interfaces.Venda;
using AxisCommerce.Infrastructure.Repositories.Autenticacao;
using AxisCommerce.Infrastructure.Repositories.Caixa;
using AxisCommerce.Infrastructure.Repositories.Clientes;
using AxisCommerce.Infrastructure.Repositories.Loja;
using AxisCommerce.Infrastructure.Repositories.Pagamento;
using AxisCommerce.Infrastructure.Repositories.Pedidos;
using AxisCommerce.Infrastructure.Repositories.Produtos;
using AxisCommerce.Infrastructure.Repositories.Venda;
using AxisCommerce.Infrastructure.Services.Autenticacao;

namespace AxisCommerce.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioService, UsuarioService>();

        services.AddScoped<ICaixaControleService, CaixaControleService>();
        services.AddScoped<ICaixaFechamentoService, CaixaFechamentoService>();
        services.AddScoped<ICaixaLancamentoService, CaixaLancamentoService>();
        services.AddScoped<ICaixaRecebimentoService, CaixaRecebimentoService>();
        services.AddScoped<ICaixaRecebimentoPgtoService, CaixaRecebimentoPgtoService>();
        services.AddScoped<ITipoLancamentoService, TipoLancamentoService>();

        services.AddScoped<IClienteClassificacaoService, ClienteClassificacaoService>();
        services.AddScoped<IClienteEscolaridadeService, ClienteEscolaridadeService>();
        services.AddScoped<IClienteFaixaRendaService, ClienteFaixaRendaService>();
        services.AddScoped<IClienteProfissaoService, ClienteProfissaoService>();
        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<IClienteSubTipoService, ClienteSubTipoService>();
        services.AddScoped<IClienteTipoService, ClienteTipoService>();

        services.AddScoped<IFornecedorService, FornecedorService>();
        services.AddScoped<ILojaControleService, LojaControleService>();
        services.AddScoped<ILojaService, LojaService>();
        services.AddScoped<ILojaHorarioService, LojaHorarioService>();
        services.AddScoped<ITerminalService, TerminalService>();
        services.AddScoped<ITransportadoraService, TransportadoraService>();
        services.AddScoped<IVendedorService, VendedorService>();

        services.AddScoped<IAdminCartaoService, AdminCartaoService>();
        services.AddScoped<ICondicaoPagtoService, CondicaoPagtoService>();
        services.AddScoped<ICondicaoPagtoParcelaService, CondicaoPagtoParcelaService>();
        services.AddScoped<ICredenciadoraCartaoService, CredenciadoraCartaoService>();
        services.AddScoped<IMoedaIndicadorService, MoedaIndicadorService>();
        services.AddScoped<IProgramaFidelidadeService, ProgramaFidelidadeService>();
        services.AddScoped<ITipoPagamentoService, TipoPagamentoService>();

        services.AddScoped<IMotivoCancelamentoService, MotivoCancelamentoService>();
        services.AddScoped<IMotivoDescontoService, MotivoDescontoService>();
        services.AddScoped<IMotivoDevolucaoService, MotivoDevolucaoService>();
        services.AddScoped<IPedidoService, PedidoService>();
        services.AddScoped<IPedidoDescontoService, PedidoDescontoService>();
        services.AddScoped<IPedidoEntregaService, PedidoEntregaService>();
        services.AddScoped<IPedidoItemService, PedidoItemService>();
        services.AddScoped<IPedidoPagtoService, PedidoPgtoService>();
        services.AddScoped<IPedidoPromocaoService, PedidoPromocaoService>();
        services.AddScoped<IPedidoVendedorService, PedidoVendedorService>();
        services.AddScoped<ITipoPedidoService, TipoPedidoService>();

        services.AddScoped<IArtigoBrindeService, ArtigoBrindeService>();
        services.AddScoped<IDepositoService, DepositoService>();
        services.AddScoped<IEstoqueService, EstoqueService>();
        services.AddScoped<IKitService, KitService>();
        services.AddScoped<IProdutoAtributoDefinicaoService, ProdutoAtributoDefinicaoService>();
        services.AddScoped<IProdutoAtributoService, ProdutoAtributoService>();
        services.AddScoped<IProdutoCatalogoService, ProdutoCatalogoService>();
        services.AddScoped<IProdutoCodigoBarraService, ProdutoCodigoBarraService>();
        services.AddScoped<IProdutoCorBasicaService, ProdutoCorBasicaService>();
        services.AddScoped<IProdutoKitService, ProdutoKitService>();
        services.AddScoped<IProdutoLookComposicaoService, ProdutoLookComposicaoService>();
        services.AddScoped<IProdutoPrecoService, ProdutoPrecoService>();
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<IProdutoTributoService, ProdutoTributoService>();
        services.AddScoped<IUnidadeMedidaService, UnidadeMedidaService>();

        services.AddScoped<IOperacaoVendaCondicaoPgtoService, OperacaoVendaCondicaoPgtoService>();
        services.AddScoped<IOperacaoVendaService, OperacaoVendaService>();
        services.AddScoped<IOperacaoVendaTipoClienteService, OperacaoVendaTipoClienteService>();
        services.AddScoped<IPromocaoGrupoService, PromocaoGrupoService>();
        services.AddScoped<IPromocaoService, PromocaoService>();
        services.AddScoped<IPromocaoTipoOfertaService, PromocaoTipoOfertaService>();
        services.AddScoped<ITipoOfertaService, TipoOfertaService>();
        services.AddScoped<ITipoOperacaoVendaService, TipoOperacaoVendaService>();

        return services;
    }

    public static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        services.AddScoped<ICaixaControleRepository, CaixaControleRepository>();
        services.AddScoped<ICaixaFechamentoRepository, CaixaFechamentoRepository>();
        services.AddScoped<ICaixaLancamentoRepository, CaixaLancamentoRepository>();
        services.AddScoped<ICaixaRecebimentoRepository, CaixaRecebimentoRepository>();
        services.AddScoped<ICaixaRecebimentoPgtoRepository, CaixaRecebimentoPgtoRepository>();
        services.AddScoped<ITipoLancamentoRepository, TipoLancamentoRepository>();

        services.AddScoped<IClienteClassificacaoRepository, ClienteClassificacaoRepository>();
        services.AddScoped<IClienteEscolaridadeRepository, ClienteEscolaridadeRepository>();
        services.AddScoped<IClienteFaixaRendaRepository, ClienteFaixaRendaRepository>();
        services.AddScoped<IClienteProfissaoRepository, ClienteProfissaoRepository>();
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IClienteSubTipoRepository, ClienteSubTipoRepository>();
        services.AddScoped<IClienteTipoRepository, ClienteTipoRepository>();

        services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        services.AddScoped<ILojaControleRepository, LojaControleRepository>();
        services.AddScoped<ILojaRepository, LojaRepository>();
        services.AddScoped<ILojaHorarioRepository, LojaHorarioRepository>();
        services.AddScoped<ITerminalRepository, TerminalRepository>();
        services.AddScoped<ITransportadoraRepository, TransportadoraRepository>();
        services.AddScoped<IVendedorRepository, VendedorRepository>();

        services.AddScoped<IAdminCartaoRepository, AdminCartaoRepository>();
        services.AddScoped<ICondicaoPagtoRepository, CondicaoPagtoRepository>();
        services.AddScoped<ICondicaoPagtoParcelaRepository, CondicaoPagtoParcelaRepository>();
        services.AddScoped<ICredenciadoraCartaoRepository, CredenciadoraCartaoRepository>();
        services.AddScoped<IMoedaIndicadorRepository, MoedaIndicadorRepository>();
        services.AddScoped<IProgramaFidelidadeRepository, ProgramaFidelidadeRepository>();
        services.AddScoped<ITipoPagamentoRepository, TipoPagamentoRepository>();

        services.AddScoped<IMotivoCancelamentoRepository, MotivoCancelamentoRepository>();
        services.AddScoped<IMotivoDescontoRepository, MotivoDescontoRepository>();
        services.AddScoped<IMotivoDevolucaoRepository, MotivoDevolucaoRepository>();
        services.AddScoped<IPedidoRepository, PedidoRepository>();
        services.AddScoped<IPedidoDescontoRepository, PedidoDescontoRepository>();
        services.AddScoped<IPedidoEntregaRepository, PedidoEntregaRepository>();
        services.AddScoped<IPedidoItemRepository, PedidoItemRepository>();
        services.AddScoped<IPedidoPagtoRepository, PedidoPagtoRepository>();
        services.AddScoped<IPedidoPromocaoRepository, PedidoPromocaoRepository>();
        services.AddScoped<IPedidoVendedorRepository, PedidoVendedorRepository>();
        services.AddScoped<ITipoPedidoRepository, TipoPedidoRepository>();

        services.AddScoped<IArtigoBrindeRepository, ArtigoBrindeRepository>();
        services.AddScoped<IDepositoRepository, DepositoRepository>();
        services.AddScoped<IEstoqueRepository, EstoqueRepository>();
        services.AddScoped<IKitRepository, KitRepository>();
        services.AddScoped<IProdutoAtributoDefinicaoRepository, ProdutoAtributoDefinicaoRepository>();
        services.AddScoped<IProdutoAtributoRepository, ProdutoAtributoRepository>();
        services.AddScoped<IProdutoCatalogoRepository, ProdutoCatalogoRepository>();
        services.AddScoped<IProdutoCodigoBarraRepository, ProdutoCodigoBarraRepository>();
        services.AddScoped<IProdutoCorBasicaRepository, ProdutoCorBasicaRepository>();
        services.AddScoped<IProdutoKitRepository, ProdutoKitRepository>();
        services.AddScoped<IProdutoLookComposicaoRepository, ProdutoLookComposicaoRepository>();
        services.AddScoped<IProdutoPrecoRepository, ProdutoPrecoRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IProdutoTributoRepository, ProdutoTributoRepository>();
        services.AddScoped<IUnidadeMedidaRepository, UnidadeMedidaRepository>();

        services.AddScoped<IOperacaoVendaCondicaoPgtoRepository, OperacaoVendaCondicaoPgtoRepository>();
        services.AddScoped<IOperacaoVendaRepository, OperacaoVendaRepository>();
        services.AddScoped<IOperacaoVendaTipoClienteRepository, OperacaoVendaTipoClienteRepository>();
        services.AddScoped<IPromocaoGrupoRepository, PromocaoGrupoRepository>();
        services.AddScoped<IPromocaoRepository, PromocaoRepository>();
        services.AddScoped<IPromocaoTipoOfertaRepository, PromocaoTipoOfertaRepository>();
        services.AddScoped<ITipoOfertaRepository, TipoOfertaRepository>();
        services.AddScoped<ITipoOperacaoVendaRepository, TipoOperacaoVendaRepository>();

        return services;
    }
}
