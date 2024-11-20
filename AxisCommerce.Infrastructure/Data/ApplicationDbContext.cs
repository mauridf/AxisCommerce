using AxisCommerce.Domain.Entities.Autenticacao;
using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Entities.Vendas;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // AUTENTICACAO
    public DbSet<Usuario> Usuarios { get; set; }
    // PRODUTO
    public DbSet<ArtigoBrinde> ArtigoBrinde { get; set; }
    public DbSet<Deposito> Deposito { get; set; }
    public DbSet<Estoque> Estoque { get; set; }
    public DbSet<Kit> Kit { get; set; }
    public DbSet<Lojas> Lojas { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoAtributo> ProdutoAtributos { get; set; }
    public DbSet<ProdutoAtributoDefinicao> ProdutoAtributoDefinicoes { get; set; }
    public DbSet<ProdutoCatalogo> ProdutoCatalogo { get; set; }
    public DbSet<ProdutoCodigoBarra> ProdutoCodigoBarra { get; set; }
    public DbSet<ProdutoCorBasica> ProdutoCorBasica { get; set; }
    public DbSet<ProdutoKit> ProdutoKits { get; set; }
    public DbSet<ProdutoLookComposicao> ProdutoLookComposicoes { get; set; }
    public DbSet<ProdutoPreco> ProdutoPrecos { get; set; }
    public DbSet<ProdutoTributo> ProdutoTributos { get; set; }
    public DbSet<PromocaoTipoOferta> PromocaoTipoOfertas { get; set; }
    public DbSet<UnidadeMedida> UnidadesMedida { get; set; }
    // CLIENTES
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ClienteEscolaridade> ClientesEscolaridade { get; set; }
    public DbSet<ClienteClassificacao> ClientesClassificacoe { get; set; }
    public DbSet<ClienteFaixaRenda> ClientesFaixaRenda { get; set; }
    public DbSet<ClienteProfissao> ClientesProfissoes { get; set; }
    public DbSet<ClienteSubTipo> ClientesSubTipos { get; set; }
    public DbSet<ClienteTipo> ClientesTipos { get; set; }
    // CAIXA
    public DbSet<CaixaControle> CaixasControle { get; set; }
    public DbSet<CaixaFechamento> CaixasFechamento { get; set; }
    public DbSet<CaixaLancamento> CaixasLancamento { get; set; }
    public DbSet<CaixaRecebimento> CaixasRecebimento { get; set; }
    public DbSet<CaixaRecebimentoPgto> CaixasRecebimentoPgto { get; set; }
    public DbSet<TipoLancamento> TiposLancamento { get; set; }
    // PAGAMENTO
    public DbSet<AdminCartao> AdminsCartao { get; set; }
    public DbSet<CondicaoPagto> CondicoesPgto { get; set; }
    public DbSet<CondicaoPagtoParcela> CondicoesPagtoParcela { get; set; }
    public DbSet<CredenciadoraCartao> CredenciadorasCartao { get; set; }
    public DbSet<MoedaIndicador> MoedasIndicador { get; set; }
    public DbSet<ProgramaFidelidade> ProgramasFidelidade { get; set; }
    public DbSet<TipoPagamento> TiposPagamento { get; set; }
    // PEDIDO
    public DbSet<MotivoCancelamento> MotivosCancelamento { get; set; }
    public DbSet<MotivoDesconto> MotivosDesconto { get; set; }
    public DbSet<MotivoDevolucao> MotivosDevolucao { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<PedidoDesconto> PedidosDesconto { get; set; }
    public DbSet<PedidoEntrega> PedidosEntregas { get; set; }
    public DbSet<PedidoItem> PedidoItens { get; set; }
    public DbSet<PedidoPagto> PedidosPgto { get; set; }
    public DbSet<PedidoPromocao> PedidosPromocao { get; set; }
    public DbSet<PedidoVendedor> PedidosVendedor { get; set; }
    public DbSet<TipoPedido> TiposPedido { get; set; }
    // VENDAS
    public DbSet<OperacaoVenda> OperacoesVenda { get; set; }
    public DbSet<OperacaoVendaCondicaoPgto> OperacoesVendasCondicoesPagto { get; set; }
    public DbSet<OperacaoVendaTipoCliente> OperacoesVendasTipoCliente { get; set; }
    public DbSet<Promocao> Promocoes { get; set; }
    public DbSet<PromocaoGrupo> PromocoesGrupo { get; set; }
    public DbSet<PromocaoTipoOferta> PromocoesTipoOferta { get; set; }
    public DbSet<TipoOferta> TiposOfertas { get; set; }
    public DbSet<TipoOperacaoVenda> TiposOperacoesVendas { get; set; }
    // LOJA
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<Lojas> Loja { get; set; }
    public DbSet<LojaControle> LojasControle { get; set; }
    public DbSet<LojaHorario> LojasHorario { get; set; }
    public DbSet<Terminal> Terminal { get; set; }
    public DbSet<Transportadora> Transportadoras { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração de Produto com UnidadeMedida
        modelBuilder.Entity<Produto>()
            .HasOne(p => p.UnidadeMedida)
            .WithMany(u => u.Produtos)
            .HasForeignKey(p => p.UnidadeMedidaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);

        // Configuração de ProdutoKit com Produto e Kit
        modelBuilder.Entity<ProdutoKit>()
            .HasOne(pk => pk.Produto)
            .WithMany(p => p.ProdutoKits)
            .HasForeignKey(pk => pk.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProdutoKit>()
            .HasOne(pk => pk.Kit)
            .WithMany()
            .HasForeignKey(pk => pk.KitId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ProdutoCodigoBarra com Produto
        modelBuilder.Entity<ProdutoCodigoBarra>()
            .HasOne(pcb => pcb.Produto)
            .WithMany(p => p.ProdutoCodigoBarra)
            .HasForeignKey(pcb => pcb.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ProdutoPreco com Produto
        modelBuilder.Entity<ProdutoPreco>()
            .HasOne(pp => pp.Produto)
            .WithMany(p => p.ProdutoPreco)
            .HasForeignKey(pp => pp.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ProdutoTributo com Produto
        modelBuilder.Entity<ProdutoTributo>()
            .HasOne(pt => pt.Produto)
            .WithMany(p => p.ProdutoTributo)
            .HasForeignKey(pt => pt.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ProdutoCatalogo com Produto e ProdutoAtributo
        modelBuilder.Entity<ProdutoCatalogo>()
            .HasOne(pc => pc.Produto)
            .WithMany(p => p.ProdutoCatalogos)
            .HasForeignKey(pc => pc.ProdutoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProdutoCatalogo>()
            .HasOne(pc => pc.ProdutoAtributo)
            .WithMany(pa => pa.ProdutoCatalogos)
            .HasForeignKey(pc => pc.ProdutoAtributoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ProdutoLookComposicao com Produto e ProdutoAtributo
        modelBuilder.Entity<ProdutoLookComposicao>()
            .HasOne(plc => plc.Produto)
            .WithMany(p => p.ProdutoLookComposicoes)
            .HasForeignKey(plc => plc.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProdutoLookComposicao>()
            .HasOne(plc => plc.ProdutoAtributo)
            .WithMany(pa => pa.ProdutoLookComposicoes)
            .HasForeignKey(plc => plc.ProdutoAtributoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ProdutoCorBasica com Produto e ProdutoAtributo
        modelBuilder.Entity<ProdutoCorBasica>()
            .HasOne(pcb => pcb.Produto)
            .WithMany(p => p.ProdutoCorBasica)
            .HasForeignKey(pcb => pcb.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProdutoCorBasica>()
            .HasOne(pcb => pcb.ProdutoAtributo)
            .WithMany(pa => pa.ProdutoCorBasica)
            .HasForeignKey(pcb => pcb.ProdutoAtributoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de Estoque com Produto
        modelBuilder.Entity<Estoque>()
            .HasOne(e => e.Produto)
            .WithMany(p => p.Estoques)
            .HasForeignKey(e => e.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ArtigoBrinde com Produto e PromocaoTipoOferta
        modelBuilder.Entity<ArtigoBrinde>()
            .HasOne(ab => ab.Produto)
            .WithMany(p => p.ArtigoBrinde)
            .HasForeignKey(ab => ab.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ArtigoBrinde>()
            .HasOne(ab => ab.PromocaoTipoOferta)
            .WithMany()
            .HasForeignKey(ab => ab.PromocaoTipoOfertaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de Cliente com ClienteEscolaridade, ClienteFaixaRenda, ClienteProfissao e ClienteSubTipo
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.ClienteEscolaridade)
            .WithMany()
            .HasForeignKey(ce => ce.ClienteEscolaridadeId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.ClienteFaixaRenda)
            .WithMany()
            .HasForeignKey(cf => cf.ClienteFaixaRendaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.ClienteProfissao)
            .WithMany()
            .HasForeignKey(cp => cp.ClienteProfissaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.ClienteSubTipo)
            .WithMany()
            .HasForeignKey(cs => cs.ClienteSubTipoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.ClienteClassificacao)
            .WithMany()
            .HasForeignKey(cc => cc.ClienteClassificacaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de ClienteSubTipo com TipoCliente
        modelBuilder.Entity<ClienteSubTipo>()
            .HasOne(cst => cst.ClienteTipo)
            .WithMany(ct => ct.ClienteSubTipos)
            .HasForeignKey(cst => cst.ClienteTipoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de CaixaControle com Gerente, OperadorCaixa e Terminal
        modelBuilder.Entity<CaixaControle>()
            .HasOne(cc => cc.Gerente)
            .WithMany()
            .HasForeignKey(cc => cc.GerenteId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict)  // Ajuste para o comportamento de exclusão
            .HasConstraintName("FK_CaixaControle_Gerente");

        modelBuilder.Entity<CaixaControle>()
            .HasOne(cc => cc.OperadorCaixa)
            .WithMany()
            .HasForeignKey(cc => cc.OperadorCaixaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict)  // Ajuste para o comportamento de exclusão
            .HasConstraintName("FK_CaixaControle_OperadorCaixa");

        modelBuilder.Entity<CaixaControle>()
            .HasOne(cc => cc.Terminal)
            .WithMany()
            .HasForeignKey(t => t.TerminalId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de CaixaFechamento com CaixaControle
        modelBuilder.Entity<CaixaFechamento>()
            .HasOne(cf => cf.CaixaControle)
            .WithMany()
            .HasForeignKey(cc => cc.CaixaControleId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de CaixaLancamento com CaixaControle, TipoLancamento e TipoPagamento
        modelBuilder.Entity<CaixaLancamento>()
            .HasOne(cl => cl.CaixaControle)
            .WithMany()
            .HasForeignKey(cc => cc.CaixaControleId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CaixaLancamento>()
            .HasOne(cl => cl.TipoLancamento)
            .WithMany()
            .HasForeignKey(tl => tl.TipoLancamentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CaixaLancamento>()
            .HasOne(cl => cl.TipoPagamento)
            .WithMany()
            .HasForeignKey(tp => tp.TipoPagamentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de CaixaRecebimento com CaixaLancamento, Vendedor e MoedaIndicador
        modelBuilder.Entity<CaixaRecebimento>()
            .HasOne(cr => cr.CaixaLancamento)
            .WithMany()
            .HasForeignKey(cl => cl.CaixaLancamentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CaixaRecebimento>()
            .HasOne(cr => cr.Gerente)
            .WithMany()
            .HasForeignKey(g => g.GerenteId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CaixaRecebimento>()
            .HasOne(cr => cr.MoedaIndicador)
            .WithMany()
            .HasForeignKey(mi => mi.MoedaIndicadorId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de CaixaRecebimentoPgto com CaixaRecebimento, TipoPagamento, AdminCartao e MoedaIndicador
        modelBuilder.Entity<CaixaRecebimentoPgto>()
            .HasOne(crp => crp.CaixaRecebimento)
            .WithMany()
            .HasForeignKey(cr => cr.CaixaRecebimentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CaixaRecebimentoPgto>()
            .HasOne(crp => crp.TipoPagamento)
            .WithMany()
            .HasForeignKey(tp => tp.TipoPagamentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CaixaRecebimentoPgto>()
            .HasOne(crp => crp.AdminCartao)
            .WithMany()
            .HasForeignKey(ac => ac.AdmCartaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CaixaRecebimentoPgto>()
            .HasOne(crp => crp.MoedaIndicador)
            .WithMany()
            .HasForeignKey(mi => mi.MoedaIndicadorId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de AdminCartao com CredenciadoraCartao
        modelBuilder.Entity<AdminCartao>()
            .HasOne(ac => ac.CredenciadoraCartao)
            .WithMany()
            .HasForeignKey(crc => crc.CredenciadoraCartaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de CondicaoPagto com TipoPagto e AdminCartao
        modelBuilder.Entity<CondicaoPagto>()
            .HasOne(cp => cp.TipoPagamento)
            .WithMany()
            .HasForeignKey(tp => tp.TipoPagtoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CondicaoPagto>()
            .HasOne(cp => cp.AdminCartao)
            .WithMany()
            .HasForeignKey(ac => ac.AdminCartaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de CondicaoPagtoParcela com CondicaoPagto, TipoPagamento e AdminCartao
        modelBuilder.Entity<CondicaoPagtoParcela>()
            .HasOne(cpp => cpp.CondicaoPgto)
            .WithMany()
            .HasForeignKey(cp => cp.CondicaoPgtoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CondicaoPagtoParcela>()
            .HasOne(cpp => cpp.TipoPagamento)
            .WithMany()
            .HasForeignKey(tp => tp.TipoPagtoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CondicaoPagtoParcela>()
            .HasOne(cpp => cpp.AdminCartao)
            .WithMany()
            .HasForeignKey(ac => ac.AdminCartaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de Pedido com Lojas, Cliente, TipoPedido, MotivoCancelamento, MotivoDesconto e MotivoDevolucao
        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Loja)
            .WithMany()
            .HasForeignKey(l => l.LojaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Cliente)
            .WithMany()
            .HasForeignKey(c => c.ClienteId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.TipoPedido)
            .WithMany()
            .HasForeignKey(tp => tp.TipoPedidoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.MotivoCancelamento)
            .WithMany()
            .HasForeignKey(mc => mc.MotivoCancelamentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.MotivoDesconto)
            .WithMany()
            .HasForeignKey(mds => mds.MotivoDescontoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.MotivoDevolucao)
            .WithMany()
            .HasForeignKey(mdv => mdv.MotivoDevolucaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de PedidoDesconto com Pedido, PedidoItem, PedidoPgto, MotivoDesconto, Vendedor e PedidoPromocao
        modelBuilder.Entity<PedidoDesconto>()
            .HasOne(pd => pd.Pedido)
            .WithMany()
            .HasForeignKey(p => p.PedidoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoDesconto>()
            .HasOne(pd => pd.PedidoItem)
            .WithMany()
            .HasForeignKey(pi => pi.PedidoItemId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoDesconto>()
            .HasOne(pd => pd.PedidoPgto)
            .WithMany()
            .HasForeignKey(pp => pp.PedidoPgtoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoDesconto>()
            .HasOne(pd => pd.MotivoDesconto)
            .WithMany()
            .HasForeignKey(md => md.MotivoDescontoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoDesconto>()
            .HasOne(pd => pd.Vendedor)
            .WithMany()
            .HasForeignKey(v => v.VendedorId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoDesconto>()
            .HasOne(pd => pd.PedidoPromocao)
            .WithMany()
            .HasForeignKey(ppr => ppr.PedidoPromocaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de PedidoEntrega com Pedido
        modelBuilder.Entity<PedidoEntrega>()
            .HasOne(pe => pe.Pedido)
            .WithMany()
            .HasForeignKey(p => p.PedidoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de PedidoItem com Pedido, Produto, ProdutoCodigoBarra, ProdutoPreco, Estoque, MotivoCancelamento, MotivoDesconto e MotivoDevolucao
        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.Pedido)
            .WithMany()
            .HasForeignKey(p => p.PedidoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.Produto)
            .WithMany()
            .HasForeignKey(prd => prd.ProdutoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.ProdutoCodigoBarra)
            .WithMany()
            .HasForeignKey(pcb => pcb.ProdutoCodigoBarraId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.ProdutoPreco)
            .WithMany()
            .HasForeignKey(ppr => ppr.ProdutoPrecoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.Estoque)
            .WithMany()
            .HasForeignKey(e => e.EstoqueId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.MotivoCancelamento)
            .WithMany()
            .HasForeignKey(mc => mc.MotivoCancelamentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.MotivoDesconto)
            .WithMany()
            .HasForeignKey(md => md.MotivoDescontoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoItem>()
            .HasOne(pi => pi.MotivoDevolucao)
            .WithMany()
            .HasForeignKey(mdv => mdv.MotivoDevolucaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de PedidoPgto com Pedido, TipoPagamento, AdminCartao, MoedaIndicador e CondicaoPagto
        modelBuilder.Entity<PedidoPagto>()
            .HasOne(pp => pp.Pedido)
            .WithMany()
            .HasForeignKey(p => p.PedidoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoPagto>()
            .HasOne(pp => pp.TipoPagamento)
            .WithMany()
            .HasForeignKey(tp => tp.TipoPagtoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoPagto>()
            .HasOne(pp => pp.AdminCartao)
            .WithMany()
            .HasForeignKey(ac => ac.AdminCartaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoPagto>()
            .HasOne(pp => pp.MoedaIndicador)
            .WithMany()
            .HasForeignKey(mi => mi.MoedaIndicadorId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoPagto>()
            .HasOne(pp => pp.CondicaoPagto)
            .WithMany()
            .HasForeignKey(cp => cp.CondicaoPagtoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de PedidoPromocao com Pedido
        modelBuilder.Entity<PedidoPromocao>()
            .HasOne(ppr => ppr.Pedido)
            .WithMany()
            .HasForeignKey(p => p.PedidoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de PedidoVendedor com Pedido e Vendedor
        modelBuilder.Entity<PedidoVendedor>()
            .HasOne(pv => pv.Pedido)
            .WithMany()
            .HasForeignKey(p => p.PedidoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PedidoVendedor>()
            .HasOne(pv => pv.Vendedor)
            .WithMany()
            .HasForeignKey(v => v.VendedorId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de OperacaoVendaCondicaoPgto com CondicaoPagto e OperacaoVenda
        modelBuilder.Entity<OperacaoVendaCondicaoPgto>()
            .HasOne(ovcp => ovcp.CondicaoPgto)
            .WithMany()
            .HasForeignKey(cp => cp.CondicaoPgtoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OperacaoVendaCondicaoPgto>()
            .HasOne(ovcp => ovcp.OperacaoVenda)
            .WithMany()
            .HasForeignKey(ov => ov.OperacaoVendaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de OperacaoVendaTipoCliente com OperacaoVenda e ClienteTipo
        modelBuilder.Entity<OperacaoVendaTipoCliente>()
            .HasOne(ovtp => ovtp.OperacaoVenda)
            .WithMany()
            .HasForeignKey(ov => ov.OperacaoVendaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OperacaoVendaTipoCliente>()
            .HasOne(ovtp => ovtp.ClienteTipo)
            .WithMany()
            .HasForeignKey(ct => ct.ClienteTipoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de Promocao com PromocaoGrupo, TipoPagamento e TipoOperacaoVenda
        modelBuilder.Entity<Promocao>()
            .HasOne(pro => pro.PromocaoGrupo)
            .WithMany()
            .HasForeignKey(pg => pg.PromocaoGrupoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Promocao>()
            .HasOne(pro => pro.TipoPagamento)
            .WithMany()
            .HasForeignKey(tp => tp.TipoPagamentoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Promocao>()
            .HasOne(pro => pro.TipoOperacaoVenda)
            .WithMany()
            .HasForeignKey(tov => tov.TipoOperacaoVendaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de PromocaoTipoOferta com Promocao e TipoOferta
        modelBuilder.Entity<PromocaoTipoOferta>()
            .HasOne(pto => pto.Promocao)
            .WithMany()
            .HasForeignKey(pro => pro.PromocaoId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PromocaoTipoOferta>()
            .HasOne(pto => pto.TipoOferta)
            .WithMany()
            .HasForeignKey(to => to.TipoOfertaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de LojaControle com Loja e Vendedor
        modelBuilder.Entity<LojaControle>()
            .HasOne(lc => lc.Loja)
            .WithMany()
            .HasForeignKey(l => l.LojaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<LojaControle>()
            .HasOne(lc => lc.Vendedor)
            .WithMany()
            .HasForeignKey(v => v.GerenteLojaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de LojaHorario com Loja
        modelBuilder.Entity<LojaHorario>()
            .HasOne(lh => lh.Loja)
            .WithMany()
            .HasForeignKey(l => l.LojaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração de LojaHorario com Loja
        modelBuilder.Entity<Terminal>()
            .HasOne(lh => lh.Loja)
            .WithMany()
            .HasForeignKey(t => t.LojaId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.ToTable("Vendedores");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.CodVendedor)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.NomeVendedor)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Apelido)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.CPF)
                .IsRequired()
                .HasMaxLength(14);

            entity.Property(e => e.DataNascimento)
                .IsRequired();

            entity.Property(e => e.DataAtivacao)
                .IsRequired()
                .HasColumnType("timestamp with time zone");

            entity.Property(e => e.DataDesativacao)
                .HasColumnType("timestamp with time zone");

            entity.Property(e => e.LoginVendedor)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.SenhaVendedor)
                .IsRequired()
                .HasMaxLength(100);

            // Constraints
            entity.HasCheckConstraint("CK_Vendedor_Gerente", "\"IndicaGerente\" IN (false, true)");
            entity.HasCheckConstraint("CK_Vendedor_OperadorCaixa", "\"IndicaOperadorCaixa\" IN (false, true)");

            // Relacionamento com Loja
            entity.HasOne(e => e.Loja)
                .WithMany() // Relacionamento com Loja, ajuste se necessário
                .HasForeignKey(e => e.LojaId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        base.OnModelCreating(modelBuilder);
    }
}
