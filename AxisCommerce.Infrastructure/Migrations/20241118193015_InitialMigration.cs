using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AxisCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientesClassificacoe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescClienteClassificacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesClassificacoe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesEscolaridade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescEscolaridade = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesEscolaridade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesFaixaRenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescClienteFaixaRenda = table.Column<string>(type: "text", nullable: true),
                    ValorDe = table.Column<string>(type: "text", nullable: false),
                    ValorAte = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesFaixaRenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesProfissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescClienteProfissao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesProfissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesTipos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescTipoCliente = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesTipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CredenciadorasCartao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CodCredenciadoraCartao = table.Column<string>(type: "text", nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredenciadorasCartao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false),
                    NomeFantasia = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Municipio = table.Column<string>(type: "text", nullable: false),
                    UF = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    DDD = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescKit = table.Column<string>(type: "text", nullable: false),
                    Qtdd = table.Column<int>(type: "integer", nullable: false),
                    PorcAbsorcaoDesconto = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CodLoja = table.Column<string>(type: "text", nullable: false),
                    DescLoja = table.Column<string>(type: "text", nullable: false),
                    NomeFantasia = table.Column<string>(type: "text", nullable: true),
                    RazaoSocial = table.Column<string>(type: "text", nullable: true),
                    IndicaPessoaJuridicaFisica = table.Column<int>(type: "integer", nullable: false),
                    CNPJ_CPF = table.Column<string>(type: "text", nullable: false),
                    InscEstadual = table.Column<string>(type: "text", nullable: false),
                    InscMunicipal = table.Column<string>(type: "text", nullable: false),
                    InscSuframa = table.Column<string>(type: "text", nullable: false),
                    TipoLogradouro = table.Column<int>(type: "integer", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    UF = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false),
                    DataAbertura = table.Column<DateOnly>(type: "date", nullable: false),
                    DataFechamento = table.Column<DateOnly>(type: "date", nullable: false),
                    DDD = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoedasIndicador",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SiglaMoedaIndicador = table.Column<string>(type: "text", nullable: false),
                    NomeMoeda = table.Column<string>(type: "text", nullable: false),
                    NomeMoedaFracao = table.Column<string>(type: "text", nullable: false),
                    NomeMoedaPlural = table.Column<string>(type: "text", nullable: false),
                    NomeMoedaFracaoPlural = table.Column<string>(type: "text", nullable: false),
                    ValorConversao = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoedasIndicador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivosCancelamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescMotivoCancelamento = table.Column<string>(type: "text", nullable: false),
                    IndicaCancelamentoItem = table.Column<bool>(type: "boolean", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosCancelamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivosDesconto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescMotivoDesconto = table.Column<string>(type: "text", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosDesconto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivosDevolucao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescMotivoDevolucao = table.Column<string>(type: "text", nullable: false),
                    AprovacaoGerente = table.Column<bool>(type: "boolean", nullable: false),
                    IndicaDevoculaoItem = table.Column<bool>(type: "boolean", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosDevolucao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperacoesVenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CodOperacaoVenda = table.Column<string>(type: "text", nullable: false),
                    DescOperacaoVenda = table.Column<string>(type: "text", nullable: false),
                    DescNaturezaOperacao = table.Column<string>(type: "text", nullable: false),
                    DataAtivar = table.Column<DateOnly>(type: "date", nullable: false),
                    DataDesativar = table.Column<DateOnly>(type: "date", nullable: true),
                    LimiteDesconto = table.Column<int>(type: "integer", nullable: false),
                    LimiteDescontoGerente = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperacoesVenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoAtributoDefinicoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdSuperior = table.Column<Guid>(type: "uuid", nullable: true),
                    DescAtributoDefinição = table.Column<string>(type: "text", nullable: false),
                    DescResumidaAtributo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoAtributoDefinicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramasFidelidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescProgramaFidelidade = table.Column<string>(type: "text", nullable: false),
                    PontuacaoDataInicio = table.Column<DateOnly>(type: "date", nullable: false),
                    PontuacaoDataFinal = table.Column<DateOnly>(type: "date", nullable: false),
                    PontuacaoFormula = table.Column<string>(type: "text", nullable: false),
                    PontuacaoRecibo = table.Column<string>(type: "text", nullable: false),
                    ResgateDataInicio = table.Column<DateOnly>(type: "date", nullable: false),
                    ResgateDataFinal = table.Column<DateOnly>(type: "date", nullable: false),
                    ResgateFormula = table.Column<string>(type: "text", nullable: false),
                    ResgateRecibo = table.Column<string>(type: "text", nullable: false),
                    ResgateSaldoMinimo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramasFidelidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromocoesGrupo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescPromocaoGrupo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromocoesGrupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposLancamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescTipoLancamento = table.Column<string>(type: "text", nullable: true),
                    IndicaSaida = table.Column<bool>(type: "boolean", nullable: false),
                    DescNaoFiscal = table.Column<string>(type: "text", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposLancamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposOfertas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CodTipoOferta = table.Column<string>(type: "text", nullable: false),
                    DescTipoOferta = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOfertas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposOperacoesVendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescTipoOperacaoVenda = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOperacoesVendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposPagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SiglaTipoPagto = table.Column<string>(type: "text", nullable: false),
                    DescTipoPagto = table.Column<string>(type: "text", nullable: false),
                    TipoAVista = table.Column<bool>(type: "boolean", nullable: false),
                    PossuiTEF = table.Column<bool>(type: "boolean", nullable: false),
                    PermiteDevolucao = table.Column<bool>(type: "boolean", nullable: false),
                    ValorMinimo = table.Column<double>(type: "double precision", nullable: false),
                    ValorMaximo = table.Column<double>(type: "double precision", nullable: false),
                    ParcelasMinimo = table.Column<int>(type: "integer", nullable: false),
                    ParcelasSugestao = table.Column<int>(type: "integer", nullable: false),
                    ParcelasMaximo = table.Column<int>(type: "integer", nullable: false),
                    DiasVencimento = table.Column<int>(type: "integer", nullable: false),
                    DiasEntreParcelas = table.Column<int>(type: "integer", nullable: false),
                    ToleranciaVencimento = table.Column<int>(type: "integer", nullable: false),
                    ToleranciaPorcentagem = table.Column<int>(type: "integer", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposPedido",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescTipoPedido = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPedido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportadoras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: false),
                    NomeFantasia = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Municipio = table.Column<string>(type: "text", nullable: false),
                    UF = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    DDD = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportadoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeUnidadeMedida = table.Column<string>(type: "text", nullable: false),
                    NomeUnidadeMedidaPlural = table.Column<string>(type: "text", nullable: false),
                    Simbolo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    SenhaHash = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesSubTipos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClienteTipoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DescClienteSubTipo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesSubTipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientesSubTipos_ClientesTipos_ClienteTipoId",
                        column: x => x.ClienteTipoId,
                        principalTable: "ClientesTipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminsCartao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CredenciadoraCartaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DescAdminCartao = table.Column<string>(type: "text", nullable: false),
                    TipoCartao = table.Column<string>(type: "text", nullable: false),
                    ParcelaJurosLoja = table.Column<int>(type: "integer", nullable: false),
                    ParcelaJurosAdminCartao = table.Column<int>(type: "integer", nullable: false),
                    TaxaJurosParcelamento = table.Column<double>(type: "double precision", nullable: false),
                    DiasPrimeiraParcela = table.Column<int>(type: "integer", nullable: false),
                    IndicaCarteiraDigital = table.Column<bool>(type: "boolean", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false),
                    CredenciadoraCartaoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminsCartao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminsCartao_CredenciadorasCartao_CredenciadoraCartaoId",
                        column: x => x.CredenciadoraCartaoId,
                        principalTable: "CredenciadorasCartao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminsCartao_CredenciadorasCartao_CredenciadoraCartaoId1",
                        column: x => x.CredenciadoraCartaoId1,
                        principalTable: "CredenciadorasCartao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deposito",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LojaId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodDeposito = table.Column<string>(type: "text", nullable: false),
                    DesDeposito = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deposito_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LojasHorario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LojaId = table.Column<Guid>(type: "uuid", nullable: false),
                    DiaFuncionamento = table.Column<int>(type: "integer", nullable: false),
                    HoraInicio = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    HoraFim = table.Column<TimeOnly>(type: "time without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LojasHorario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LojasHorario_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terminal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LojaId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodTerminal = table.Column<string>(type: "text", nullable: false),
                    DescTerminal = table.Column<string>(type: "text", nullable: false),
                    DataHoraLogin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataHoraLogout = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LojasId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terminal_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Terminal_Lojas_LojasId",
                        column: x => x.LojasId,
                        principalTable: "Lojas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LojaId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodVendedor = table.Column<string>(type: "text", nullable: false),
                    NomeVendedor = table.Column<string>(type: "text", nullable: false),
                    IndicaGerente = table.Column<bool>(type: "boolean", nullable: false),
                    IndicaOperadorCaixa = table.Column<bool>(type: "boolean", nullable: false),
                    Apelido = table.Column<string>(type: "text", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    DataAtivacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataDesativacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LoginVendedor = table.Column<string>(type: "text", nullable: false),
                    SenhaVendedor = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                    table.CheckConstraint("CK_Vendedor_Gerente", "\"IndicaGerente\" IN (false, true)");  // Correção aqui
                    table.CheckConstraint("CK_Vendedor_OperadorCaixa", "\"IndicaOperadorCaixa\" IN (false, true)");  // Correção aqui
                    table.ForeignKey(
                        name: "FK_Vendedores_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperacoesVendasTipoCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OperacaoVendaId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClienteTipoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClienteTipoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    OperacaoVendaId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperacoesVendasTipoCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperacoesVendasTipoCliente_ClientesTipos_ClienteTipoId",
                        column: x => x.ClienteTipoId,
                        principalTable: "ClientesTipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperacoesVendasTipoCliente_ClientesTipos_ClienteTipoId1",
                        column: x => x.ClienteTipoId1,
                        principalTable: "ClientesTipos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperacoesVendasTipoCliente_OperacoesVenda_OperacaoVendaId",
                        column: x => x.OperacaoVendaId,
                        principalTable: "OperacoesVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperacoesVendasTipoCliente_OperacoesVenda_OperacaoVendaId1",
                        column: x => x.OperacaoVendaId1,
                        principalTable: "OperacoesVenda",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProdutoAtributos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoAtributoDefinicaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodAtributo = table.Column<string>(type: "text", nullable: false),
                    DescAtributo = table.Column<string>(type: "text", nullable: false),
                    DescAtributoResumido = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoAtributos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoAtributos_ProdutoAtributoDefinicoes_ProdutoAtributoD~",
                        column: x => x.ProdutoAtributoDefinicaoId,
                        principalTable: "ProdutoAtributoDefinicoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promocoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PromocaoGrupoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataCadastro = table.Column<DateOnly>(type: "date", nullable: false),
                    DescPromocao = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DataAtivar = table.Column<DateOnly>(type: "date", nullable: false),
                    DataDesativar = table.Column<DateOnly>(type: "date", nullable: true),
                    TipoPagamentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoOperacaoVendaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false),
                    QtddLimite = table.Column<int>(type: "integer", nullable: false),
                    URL = table.Column<string>(type: "text", nullable: false),
                    PromocaoGrupoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoOperacaoVendaId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoPagamentoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promocoes_PromocoesGrupo_PromocaoGrupoId",
                        column: x => x.PromocaoGrupoId,
                        principalTable: "PromocoesGrupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promocoes_PromocoesGrupo_PromocaoGrupoId1",
                        column: x => x.PromocaoGrupoId1,
                        principalTable: "PromocoesGrupo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Promocoes_TiposOperacoesVendas_TipoOperacaoVendaId",
                        column: x => x.TipoOperacaoVendaId,
                        principalTable: "TiposOperacoesVendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promocoes_TiposOperacoesVendas_TipoOperacaoVendaId1",
                        column: x => x.TipoOperacaoVendaId1,
                        principalTable: "TiposOperacoesVendas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Promocoes_TiposPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promocoes_TiposPagamento_TipoPagamentoId1",
                        column: x => x.TipoPagamentoId1,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DescProduto = table.Column<string>(type: "text", nullable: false),
                    CodProduto = table.Column<string>(type: "text", nullable: false),
                    UnidadeMedidaId = table.Column<Guid>(type: "uuid", nullable: false),
                    PesoProduto = table.Column<double>(type: "double precision", nullable: false),
                    EstoqueLocalProduto = table.Column<int>(type: "integer", nullable: false),
                    EstoqueLocalProdutoLimiteMinimo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_UnidadesMedida_UnidadeMedidaId",
                        column: x => x.UnidadeMedidaId,
                        principalTable: "UnidadesMedida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeCliente = table.Column<string>(type: "text", nullable: true),
                    CPFCliente = table.Column<string>(type: "text", nullable: true),
                    CNPJCliente = table.Column<string>(type: "text", nullable: true),
                    TelefoneCliente = table.Column<string>(type: "text", nullable: true),
                    EmailCliente = table.Column<string>(type: "text", nullable: true),
                    EnderecoCliente = table.Column<string>(type: "text", nullable: true),
                    CEPCliente = table.Column<string>(type: "text", nullable: true),
                    UFCliente = table.Column<string>(type: "text", nullable: true),
                    ClienteEscolaridadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteFaixaRendaId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteProfissaoId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteSubTipoId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteClassificacaoId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteClassificacaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteEscolaridadeId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteFaixaRendaId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteProfissaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    ClienteSubTipoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesClassificacoe_ClienteClassificacaoId",
                        column: x => x.ClienteClassificacaoId,
                        principalTable: "ClientesClassificacoe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesClassificacoe_ClienteClassificacaoId1",
                        column: x => x.ClienteClassificacaoId1,
                        principalTable: "ClientesClassificacoe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesEscolaridade_ClienteEscolaridadeId",
                        column: x => x.ClienteEscolaridadeId,
                        principalTable: "ClientesEscolaridade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesEscolaridade_ClienteEscolaridadeId1",
                        column: x => x.ClienteEscolaridadeId1,
                        principalTable: "ClientesEscolaridade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesFaixaRenda_ClienteFaixaRendaId",
                        column: x => x.ClienteFaixaRendaId,
                        principalTable: "ClientesFaixaRenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesFaixaRenda_ClienteFaixaRendaId1",
                        column: x => x.ClienteFaixaRendaId1,
                        principalTable: "ClientesFaixaRenda",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesProfissoes_ClienteProfissaoId",
                        column: x => x.ClienteProfissaoId,
                        principalTable: "ClientesProfissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesProfissoes_ClienteProfissaoId1",
                        column: x => x.ClienteProfissaoId1,
                        principalTable: "ClientesProfissoes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesSubTipos_ClienteSubTipoId",
                        column: x => x.ClienteSubTipoId,
                        principalTable: "ClientesSubTipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesSubTipos_ClienteSubTipoId1",
                        column: x => x.ClienteSubTipoId1,
                        principalTable: "ClientesSubTipos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CondicoesPgto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoPagtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdminCartaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodCondicaoPgto = table.Column<string>(type: "text", nullable: false),
                    DescCondicaoPgto = table.Column<string>(type: "text", nullable: false),
                    DataAtivar = table.Column<DateOnly>(type: "date", nullable: false),
                    DataDesativar = table.Column<DateOnly>(type: "date", nullable: true),
                    ValorMinimo = table.Column<double>(type: "double precision", nullable: false),
                    ValorMaximo = table.Column<double>(type: "double precision", nullable: false),
                    PorcentagemDescontoTotal = table.Column<int>(type: "integer", nullable: false),
                    DataCriacao = table.Column<DateOnly>(type: "date", nullable: false),
                    ParcelasMinimas = table.Column<int>(type: "integer", nullable: false),
                    ParcelasMaximas = table.Column<int>(type: "integer", nullable: false),
                    ParcelasSugestao = table.Column<int>(type: "integer", nullable: false),
                    DiasVencimento = table.Column<int>(type: "integer", nullable: false),
                    DiasEntreParcelas = table.Column<int>(type: "integer", nullable: false),
                    ToleranciaVencimento = table.Column<int>(type: "integer", nullable: false),
                    ToleranciaPorcentagem = table.Column<int>(type: "integer", nullable: false),
                    DiaVencimentoFixo = table.Column<int>(type: "integer", nullable: false),
                    AdminCartaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoPagamentoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicoesPgto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CondicoesPgto_AdminsCartao_AdminCartaoId",
                        column: x => x.AdminCartaoId,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CondicoesPgto_AdminsCartao_AdminCartaoId1",
                        column: x => x.AdminCartaoId1,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CondicoesPgto_TiposPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CondicoesPgto_TiposPagamento_TipoPagtoId",
                        column: x => x.TipoPagtoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaixasControle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GerenteId = table.Column<Guid>(type: "uuid", nullable: false),
                    OperadorCaixaId = table.Column<Guid>(type: "uuid", nullable: false),
                    TerminalId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataHoraAbertura = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataHoraFechamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TerminalId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    VendedorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasControle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaixaControle_Gerente",
                        column: x => x.GerenteId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaixaControle_OperadorCaixa",
                        column: x => x.OperadorCaixaId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaixasControle_Terminal_TerminalId",
                        column: x => x.TerminalId,
                        principalTable: "Terminal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasControle_Terminal_TerminalId1",
                        column: x => x.TerminalId1,
                        principalTable: "Terminal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasControle_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LojasControle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LojaId = table.Column<Guid>(type: "uuid", nullable: false),
                    GerenteLojaId = table.Column<Guid>(type: "uuid", nullable: false),
                    LojaDataControle = table.Column<DateOnly>(type: "date", nullable: false),
                    LojasId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LojasControle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LojasControle_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LojasControle_Lojas_LojasId",
                        column: x => x.LojasId,
                        principalTable: "Lojas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LojasControle_Vendedores_GerenteLojaId",
                        column: x => x.GerenteLojaId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromocaoTipoOferta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PromocaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoOfertaId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValorMinimo = table.Column<double>(type: "double precision", nullable: false),
                    QtdBrindCumpom = table.Column<int>(type: "integer", nullable: false),
                    QdtMinima = table.Column<int>(type: "integer", nullable: false),
                    ValorDesconto = table.Column<double>(type: "double precision", nullable: false),
                    PorcentagemDesconto = table.Column<int>(type: "integer", nullable: false),
                    QtdMaximaPorCliente = table.Column<int>(type: "integer", nullable: false),
                    TextoComprovante = table.Column<string>(type: "text", nullable: false),
                    MsgInternet = table.Column<string>(type: "text", nullable: false),
                    MsgOperador = table.Column<string>(type: "text", nullable: false),
                    DescBeneficio = table.Column<string>(type: "text", nullable: false),
                    DescRegra = table.Column<string>(type: "text", nullable: false),
                    PromocaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoOfertaId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromocaoTipoOferta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromocaoTipoOferta_Promocoes_PromocaoId",
                        column: x => x.PromocaoId,
                        principalTable: "Promocoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromocaoTipoOferta_Promocoes_PromocaoId1",
                        column: x => x.PromocaoId1,
                        principalTable: "Promocoes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PromocaoTipoOferta_TiposOfertas_TipoOfertaId",
                        column: x => x.TipoOfertaId,
                        principalTable: "TiposOfertas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromocaoTipoOferta_TiposOfertas_TipoOfertaId1",
                        column: x => x.TipoOfertaId1,
                        principalTable: "TiposOfertas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DepositoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    QtddEstoque = table.Column<int>(type: "integer", nullable: false),
                    DataAtualizacaoEstoque = table.Column<DateOnly>(type: "date", nullable: false),
                    QttdEstoqueLimiteMinino = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoque_Deposito_DepositoId",
                        column: x => x.DepositoId,
                        principalTable: "Deposito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estoque_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCatalogo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoAtributoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataInicialCatalogo = table.Column<DateOnly>(type: "date", nullable: false),
                    DataFinalCatalogo = table.Column<DateOnly>(type: "date", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    IndicaLook = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCatalogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoCatalogo_ProdutoAtributos_ProdutoAtributoId",
                        column: x => x.ProdutoAtributoId,
                        principalTable: "ProdutoAtributos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoCatalogo_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCodigoBarra",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodigoBarra = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCodigoBarra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoCodigoBarra_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCorBasica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoAtributoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCorBasica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoCorBasica_ProdutoAtributos_ProdutoAtributoId",
                        column: x => x.ProdutoAtributoId,
                        principalTable: "ProdutoAtributos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoCorBasica_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoKits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    KitId = table.Column<Guid>(type: "uuid", nullable: false),
                    KitId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoKits_Kit_KitId",
                        column: x => x.KitId,
                        principalTable: "Kit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoKits_Kit_KitId1",
                        column: x => x.KitId1,
                        principalTable: "Kit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoKits_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoLookComposicoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoAtributoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoLookComposicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoLookComposicoes_ProdutoAtributos_ProdutoAtributoId",
                        column: x => x.ProdutoAtributoId,
                        principalTable: "ProdutoAtributos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoLookComposicoes_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoPrecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Preco = table.Column<double>(type: "double precision", nullable: false),
                    LimiteDesconto = table.Column<double>(type: "double precision", nullable: false),
                    DataInicioVigencia = table.Column<DateOnly>(type: "date", nullable: false),
                    DataFimVigencia = table.Column<DateOnly>(type: "date", nullable: true),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPrecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoPrecos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoTributos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataInicioVigencia = table.Column<DateOnly>(type: "date", nullable: false),
                    TaxaFederal = table.Column<double>(type: "double precision", nullable: false),
                    TaxaEstadual = table.Column<double>(type: "double precision", nullable: false),
                    TaxaMunicipal = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoTributos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoTributos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LojaId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodLoja = table.Column<string>(type: "text", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uuid", nullable: false),
                    NumeroPedido = table.Column<string>(type: "text", nullable: false),
                    IdentificacaoPedido = table.Column<string>(type: "text", nullable: false),
                    DataPedido = table.Column<DateOnly>(type: "date", nullable: false),
                    TipoPedidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusPedido = table.Column<int>(type: "integer", nullable: false),
                    QtddTotal = table.Column<int>(type: "integer", nullable: false),
                    ValorTotalBruto = table.Column<double>(type: "double precision", nullable: false),
                    ValorDesconto = table.Column<double>(type: "double precision", nullable: false),
                    ValorTotalLiquido = table.Column<double>(type: "double precision", nullable: false),
                    MotivoCancelamentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MotivoDescontoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MotivoDevolucaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrigemPedido = table.Column<int>(type: "integer", nullable: false),
                    TipoEntrega = table.Column<int>(type: "integer", nullable: false),
                    HoraInicioPedido = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    DataHoraFimPedido = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    VoucherPromocional = table.Column<string>(type: "text", nullable: true),
                    IndicaFidelidade = table.Column<bool>(type: "boolean", nullable: false),
                    FidelidadePontosUtilizados = table.Column<int>(type: "integer", nullable: false),
                    ClienteId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    LojasId = table.Column<Guid>(type: "uuid", nullable: true),
                    MotivoCancelamentoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MotivoDescontoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MotivoDevolucaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoPedidoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId1",
                        column: x => x.ClienteId1,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedidos_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Lojas_LojasId",
                        column: x => x.LojasId,
                        principalTable: "Lojas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedidos_MotivosCancelamento_MotivoCancelamentoId",
                        column: x => x.MotivoCancelamentoId,
                        principalTable: "MotivosCancelamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_MotivosCancelamento_MotivoCancelamentoId1",
                        column: x => x.MotivoCancelamentoId1,
                        principalTable: "MotivosCancelamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedidos_MotivosDesconto_MotivoDescontoId",
                        column: x => x.MotivoDescontoId,
                        principalTable: "MotivosDesconto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_MotivosDesconto_MotivoDescontoId1",
                        column: x => x.MotivoDescontoId1,
                        principalTable: "MotivosDesconto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedidos_MotivosDevolucao_MotivoDevolucaoId",
                        column: x => x.MotivoDevolucaoId,
                        principalTable: "MotivosDevolucao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_MotivosDevolucao_MotivoDevolucaoId1",
                        column: x => x.MotivoDevolucaoId1,
                        principalTable: "MotivosDevolucao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedidos_TiposPedido_TipoPedidoId",
                        column: x => x.TipoPedidoId,
                        principalTable: "TiposPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_TiposPedido_TipoPedidoId1",
                        column: x => x.TipoPedidoId1,
                        principalTable: "TiposPedido",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CondicoesPagtoParcela",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CondicaoPgtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Parcela = table.Column<int>(type: "integer", nullable: false),
                    DiasDaData = table.Column<int>(type: "integer", nullable: false),
                    Porcentagem = table.Column<int>(type: "integer", nullable: false),
                    TipoPagtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdminCartaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdminCartaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CondicaoPagtoId = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoPagamentoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicoesPagtoParcela", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CondicoesPagtoParcela_AdminsCartao_AdminCartaoId",
                        column: x => x.AdminCartaoId,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CondicoesPagtoParcela_AdminsCartao_AdminCartaoId1",
                        column: x => x.AdminCartaoId1,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CondicoesPagtoParcela_CondicoesPgto_CondicaoPagtoId",
                        column: x => x.CondicaoPagtoId,
                        principalTable: "CondicoesPgto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CondicoesPagtoParcela_CondicoesPgto_CondicaoPgtoId",
                        column: x => x.CondicaoPgtoId,
                        principalTable: "CondicoesPgto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CondicoesPagtoParcela_TiposPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CondicoesPagtoParcela_TiposPagamento_TipoPagtoId",
                        column: x => x.TipoPagtoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperacoesVendasCondicoesPagto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CondicaoPgtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    OperacaoVendaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Inativo = table.Column<bool>(type: "boolean", nullable: false),
                    CondicaoPagtoId = table.Column<Guid>(type: "uuid", nullable: true),
                    OperacaoVendaId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperacoesVendasCondicoesPagto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperacoesVendasCondicoesPagto_CondicoesPgto_CondicaoPagtoId",
                        column: x => x.CondicaoPagtoId,
                        principalTable: "CondicoesPgto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperacoesVendasCondicoesPagto_CondicoesPgto_CondicaoPgtoId",
                        column: x => x.CondicaoPgtoId,
                        principalTable: "CondicoesPgto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperacoesVendasCondicoesPagto_OperacoesVenda_OperacaoVendaId",
                        column: x => x.OperacaoVendaId,
                        principalTable: "OperacoesVenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperacoesVendasCondicoesPagto_OperacoesVenda_OperacaoVendaI~",
                        column: x => x.OperacaoVendaId1,
                        principalTable: "OperacoesVenda",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CaixasFechamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CaixaControleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValorFechamentoCaixa = table.Column<double>(type: "double precision", nullable: false),
                    Justificativa = table.Column<string>(type: "text", nullable: true),
                    CaixaControleId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasFechamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaixasFechamento_CaixasControle_CaixaControleId",
                        column: x => x.CaixaControleId,
                        principalTable: "CaixasControle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasFechamento_CaixasControle_CaixaControleId1",
                        column: x => x.CaixaControleId1,
                        principalTable: "CaixasControle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CaixasLancamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CaixaControleId = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoLancamentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoPagamentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataHoraLancamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Valor = table.Column<double>(type: "double precision", nullable: true),
                    Cancelado = table.Column<bool>(type: "boolean", nullable: false),
                    DataHoraCancelado = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CaixaControleId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoLancamentoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoPagamentoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasLancamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaixasLancamento_CaixasControle_CaixaControleId",
                        column: x => x.CaixaControleId,
                        principalTable: "CaixasControle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasLancamento_CaixasControle_CaixaControleId1",
                        column: x => x.CaixaControleId1,
                        principalTable: "CaixasControle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasLancamento_TiposLancamento_TipoLancamentoId",
                        column: x => x.TipoLancamentoId,
                        principalTable: "TiposLancamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasLancamento_TiposLancamento_TipoLancamentoId1",
                        column: x => x.TipoLancamentoId1,
                        principalTable: "TiposLancamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasLancamento_TiposPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasLancamento_TiposPagamento_TipoPagamentoId1",
                        column: x => x.TipoPagamentoId1,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArtigoBrinde",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PromocaoTipoOfertaId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    QtdPecas = table.Column<int>(type: "integer", nullable: false),
                    PromocaoTipoOfertaId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtigoBrinde", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtigoBrinde_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoBrinde_PromocaoTipoOferta_PromocaoTipoOfertaId",
                        column: x => x.PromocaoTipoOfertaId,
                        principalTable: "PromocaoTipoOferta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoBrinde_PromocaoTipoOferta_PromocaoTipoOfertaId1",
                        column: x => x.PromocaoTipoOfertaId1,
                        principalTable: "PromocaoTipoOferta",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidoItens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoCodigoBarraId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProdutoPrecoId = table.Column<Guid>(type: "uuid", nullable: false),
                    EstoqueId = table.Column<Guid>(type: "uuid", nullable: false),
                    SeqItem = table.Column<int>(type: "integer", nullable: false),
                    IndicaEmbrulhaPresente = table.Column<bool>(type: "boolean", nullable: false),
                    QtddItem = table.Column<int>(type: "integer", nullable: false),
                    PrecoBrutoItem = table.Column<double>(type: "double precision", nullable: false),
                    DescontoItem = table.Column<int>(type: "integer", nullable: false),
                    PrecoLiquidoItem = table.Column<double>(type: "double precision", nullable: false),
                    ItemCancelado = table.Column<bool>(type: "boolean", nullable: false),
                    SeqKit = table.Column<int>(type: "integer", nullable: false),
                    MotivoCancelamentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MotivoDescontoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MotivoDevolucaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    UrlImagem = table.Column<string>(type: "text", nullable: true),
                    URLSite = table.Column<string>(type: "text", nullable: true),
                    ValorFrete = table.Column<double>(type: "double precision", nullable: false),
                    TaxaManuseiro = table.Column<double>(type: "double precision", nullable: false),
                    QRCode = table.Column<string>(type: "text", nullable: true),
                    IndicaBrinde = table.Column<bool>(type: "boolean", nullable: false),
                    EstoqueId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MotivoCancelamentoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MotivoDescontoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MotivoDevolucaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    PedidoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    ProdutoCodigoBarraId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    ProdutoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    ProdutoPrecoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoItens_Estoque_EstoqueId",
                        column: x => x.EstoqueId,
                        principalTable: "Estoque",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_Estoque_EstoqueId1",
                        column: x => x.EstoqueId1,
                        principalTable: "Estoque",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItens_MotivosCancelamento_MotivoCancelamentoId",
                        column: x => x.MotivoCancelamentoId,
                        principalTable: "MotivosCancelamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_MotivosCancelamento_MotivoCancelamentoId1",
                        column: x => x.MotivoCancelamentoId1,
                        principalTable: "MotivosCancelamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItens_MotivosDesconto_MotivoDescontoId",
                        column: x => x.MotivoDescontoId,
                        principalTable: "MotivosDesconto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_MotivosDesconto_MotivoDescontoId1",
                        column: x => x.MotivoDescontoId1,
                        principalTable: "MotivosDesconto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItens_MotivosDevolucao_MotivoDevolucaoId",
                        column: x => x.MotivoDevolucaoId,
                        principalTable: "MotivosDevolucao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_MotivosDevolucao_MotivoDevolucaoId1",
                        column: x => x.MotivoDevolucaoId1,
                        principalTable: "MotivosDevolucao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItens_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItens_ProdutoCodigoBarra_ProdutoCodigoBarraId",
                        column: x => x.ProdutoCodigoBarraId,
                        principalTable: "ProdutoCodigoBarra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_ProdutoCodigoBarra_ProdutoCodigoBarraId1",
                        column: x => x.ProdutoCodigoBarraId1,
                        principalTable: "ProdutoCodigoBarra",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItens_ProdutoPrecos_ProdutoPrecoId",
                        column: x => x.ProdutoPrecoId,
                        principalTable: "ProdutoPrecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_ProdutoPrecos_ProdutoPrecoId1",
                        column: x => x.ProdutoPrecoId1,
                        principalTable: "ProdutoPrecos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidoItens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoItens_Produtos_ProdutoId1",
                        column: x => x.ProdutoId1,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidosEntregas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    EnderecoEntrega = table.Column<string>(type: "text", nullable: false),
                    EnderecoCobranca = table.Column<string>(type: "text", nullable: false),
                    PeriodoEntrega = table.Column<string>(type: "text", nullable: false),
                    ValorFrete = table.Column<double>(type: "double precision", nullable: false),
                    DescontoFrete = table.Column<double>(type: "double precision", nullable: false),
                    ValorSeguro = table.Column<double>(type: "double precision", nullable: false),
                    Peso = table.Column<int>(type: "integer", nullable: false),
                    MensagemCartao = table.Column<string>(type: "text", nullable: false),
                    ObsEntrega = table.Column<string>(type: "text", nullable: false),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    OpcaoEntrega = table.Column<string>(type: "text", nullable: false),
                    SeqEntrega = table.Column<int>(type: "integer", nullable: false),
                    TaxaManuseio = table.Column<double>(type: "double precision", nullable: false),
                    TransportadoraId = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosEntregas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosEntregas_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosEntregas_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosEntregas_Transportadoras_TransportadoraId",
                        column: x => x.TransportadoraId,
                        principalTable: "Transportadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidosPgto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoPagtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdminCartaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MoedaIndicadorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Parcela = table.Column<int>(type: "integer", nullable: false),
                    Valor = table.Column<double>(type: "double precision", nullable: false),
                    Vencimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Banco = table.Column<string>(type: "text", nullable: false),
                    Agencia = table.Column<string>(type: "text", nullable: false),
                    ContaCorrente = table.Column<string>(type: "text", nullable: false),
                    ParcelasCartao = table.Column<int>(type: "integer", nullable: false),
                    CondicaoPagtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    BinCartao = table.Column<string>(type: "text", nullable: false),
                    UltimosQuatroDigitosCartao = table.Column<string>(type: "text", nullable: false),
                    ValidadeCartao = table.Column<DateOnly>(type: "date", nullable: false),
                    NomeClienteCartao = table.Column<string>(type: "text", nullable: false),
                    Troco = table.Column<double>(type: "double precision", nullable: false),
                    AdminCartaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    CondicaoPagtoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MoedaIndicadorId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    PedidoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoPagamentoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosPgto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosPgto_AdminsCartao_AdminCartaoId",
                        column: x => x.AdminCartaoId,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosPgto_AdminsCartao_AdminCartaoId1",
                        column: x => x.AdminCartaoId1,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosPgto_CondicoesPgto_CondicaoPagtoId",
                        column: x => x.CondicaoPagtoId,
                        principalTable: "CondicoesPgto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosPgto_CondicoesPgto_CondicaoPagtoId1",
                        column: x => x.CondicaoPagtoId1,
                        principalTable: "CondicoesPgto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosPgto_MoedasIndicador_MoedaIndicadorId",
                        column: x => x.MoedaIndicadorId,
                        principalTable: "MoedasIndicador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosPgto_MoedasIndicador_MoedaIndicadorId1",
                        column: x => x.MoedaIndicadorId1,
                        principalTable: "MoedasIndicador",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosPgto_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosPgto_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosPgto_TiposPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosPgto_TiposPagamento_TipoPagtoId",
                        column: x => x.TipoPagtoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidosPromocao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValorDescontoEfetivo = table.Column<double>(type: "double precision", nullable: false),
                    PedidoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosPromocao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosPromocao_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosPromocao_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidosVendedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VendedorId = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    VendedorId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosVendedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosVendedor_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosVendedor_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosVendedor_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosVendedor_Vendedores_VendedorId1",
                        column: x => x.VendedorId1,
                        principalTable: "Vendedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CaixasRecebimento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CaixaLancamentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    GerenteId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValorOriginal = table.Column<double>(type: "double precision", nullable: false),
                    ValorEncargo = table.Column<double>(type: "double precision", nullable: false),
                    ValorDesconto = table.Column<double>(type: "double precision", nullable: false),
                    ValorTotal = table.Column<double>(type: "double precision", nullable: false),
                    MoedaIndicadorId = table.Column<Guid>(type: "uuid", nullable: false),
                    CaixaLancamentoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MoedaIndicadorId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    VendedorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasRecebimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimento_CaixasLancamento_CaixaLancamentoId",
                        column: x => x.CaixaLancamentoId,
                        principalTable: "CaixasLancamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimento_CaixasLancamento_CaixaLancamentoId1",
                        column: x => x.CaixaLancamentoId1,
                        principalTable: "CaixasLancamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasRecebimento_MoedasIndicador_MoedaIndicadorId",
                        column: x => x.MoedaIndicadorId,
                        principalTable: "MoedasIndicador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimento_MoedasIndicador_MoedaIndicadorId1",
                        column: x => x.MoedaIndicadorId1,
                        principalTable: "MoedasIndicador",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasRecebimento_Vendedores_GerenteId",
                        column: x => x.GerenteId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimento_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidosDesconto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoPgtoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MotivoDescontoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VendedorId = table.Column<Guid>(type: "uuid", nullable: false),
                    PedidoPromocaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValorDesconto = table.Column<double>(type: "double precision", nullable: false),
                    ValorAcrescimo = table.Column<double>(type: "double precision", nullable: false),
                    CupomDesconto = table.Column<string>(type: "text", nullable: false),
                    Mensagem = table.Column<string>(type: "text", nullable: false),
                    MotivoDescontoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    PedidoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    PedidoItemId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    PedidoPagtoId = table.Column<Guid>(type: "uuid", nullable: true),
                    PedidoPromocaoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    VendedorId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosDesconto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_MotivosDesconto_MotivoDescontoId",
                        column: x => x.MotivoDescontoId,
                        principalTable: "MotivosDesconto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_MotivosDesconto_MotivoDescontoId1",
                        column: x => x.MotivoDescontoId1,
                        principalTable: "MotivosDesconto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_PedidoItens_PedidoItemId",
                        column: x => x.PedidoItemId,
                        principalTable: "PedidoItens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_PedidoItens_PedidoItemId1",
                        column: x => x.PedidoItemId1,
                        principalTable: "PedidoItens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_PedidosPgto_PedidoPagtoId",
                        column: x => x.PedidoPagtoId,
                        principalTable: "PedidosPgto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_PedidosPgto_PedidoPgtoId",
                        column: x => x.PedidoPgtoId,
                        principalTable: "PedidosPgto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_PedidosPromocao_PedidoPromocaoId",
                        column: x => x.PedidoPromocaoId,
                        principalTable: "PedidosPromocao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_PedidosPromocao_PedidoPromocaoId1",
                        column: x => x.PedidoPromocaoId1,
                        principalTable: "PedidosPromocao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_Pedidos_PedidoId1",
                        column: x => x.PedidoId1,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosDesconto_Vendedores_VendedorId1",
                        column: x => x.VendedorId1,
                        principalTable: "Vendedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CaixasRecebimentoPgto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CaixaRecebimentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataVencimento = table.Column<DateOnly>(type: "date", nullable: false),
                    ChequeCartao = table.Column<string>(type: "text", nullable: false),
                    TipoPagamentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    AdmCartaoId = table.Column<Guid>(type: "uuid", nullable: false),
                    MoedaIndicadorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Banco = table.Column<string>(type: "text", nullable: true),
                    Agencia = table.Column<string>(type: "text", nullable: true),
                    ContaCorrente = table.Column<string>(type: "text", nullable: true),
                    NumeroTitulo = table.Column<string>(type: "text", nullable: true),
                    ChequeDigito = table.Column<string>(type: "text", nullable: true),
                    ParcelasCartao = table.Column<int>(type: "integer", nullable: false),
                    Troco = table.Column<double>(type: "double precision", nullable: false),
                    Cotacao = table.Column<double>(type: "double precision", nullable: false),
                    ValorMoeda = table.Column<double>(type: "double precision", nullable: false),
                    AdminCartaoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CaixaRecebimentoId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MoedaIndicadorId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoPagamentoId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasRecebimentoPgto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_AdminsCartao_AdmCartaoId",
                        column: x => x.AdmCartaoId,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_AdminsCartao_AdminCartaoId",
                        column: x => x.AdminCartaoId,
                        principalTable: "AdminsCartao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_CaixasRecebimento_CaixaRecebimentoId",
                        column: x => x.CaixaRecebimentoId,
                        principalTable: "CaixasRecebimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_CaixasRecebimento_CaixaRecebimentoId1",
                        column: x => x.CaixaRecebimentoId1,
                        principalTable: "CaixasRecebimento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_MoedasIndicador_MoedaIndicadorId",
                        column: x => x.MoedaIndicadorId,
                        principalTable: "MoedasIndicador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_MoedasIndicador_MoedaIndicadorId1",
                        column: x => x.MoedaIndicadorId1,
                        principalTable: "MoedasIndicador",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_TiposPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasRecebimentoPgto_TiposPagamento_TipoPagamentoId1",
                        column: x => x.TipoPagamentoId1,
                        principalTable: "TiposPagamento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminsCartao_CredenciadoraCartaoId",
                table: "AdminsCartao",
                column: "CredenciadoraCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminsCartao_CredenciadoraCartaoId1",
                table: "AdminsCartao",
                column: "CredenciadoraCartaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoBrinde_ProdutoId",
                table: "ArtigoBrinde",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoBrinde_PromocaoTipoOfertaId",
                table: "ArtigoBrinde",
                column: "PromocaoTipoOfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoBrinde_PromocaoTipoOfertaId1",
                table: "ArtigoBrinde",
                column: "PromocaoTipoOfertaId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasControle_GerenteId",
                table: "CaixasControle",
                column: "GerenteId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasControle_OperadorCaixaId",
                table: "CaixasControle",
                column: "OperadorCaixaId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasControle_TerminalId",
                table: "CaixasControle",
                column: "TerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasControle_TerminalId1",
                table: "CaixasControle",
                column: "TerminalId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasControle_VendedorId",
                table: "CaixasControle",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasFechamento_CaixaControleId",
                table: "CaixasFechamento",
                column: "CaixaControleId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasFechamento_CaixaControleId1",
                table: "CaixasFechamento",
                column: "CaixaControleId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasLancamento_CaixaControleId",
                table: "CaixasLancamento",
                column: "CaixaControleId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasLancamento_CaixaControleId1",
                table: "CaixasLancamento",
                column: "CaixaControleId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasLancamento_TipoLancamentoId",
                table: "CaixasLancamento",
                column: "TipoLancamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasLancamento_TipoLancamentoId1",
                table: "CaixasLancamento",
                column: "TipoLancamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasLancamento_TipoPagamentoId",
                table: "CaixasLancamento",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasLancamento_TipoPagamentoId1",
                table: "CaixasLancamento",
                column: "TipoPagamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimento_CaixaLancamentoId",
                table: "CaixasRecebimento",
                column: "CaixaLancamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimento_CaixaLancamentoId1",
                table: "CaixasRecebimento",
                column: "CaixaLancamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimento_GerenteId",
                table: "CaixasRecebimento",
                column: "GerenteId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimento_MoedaIndicadorId",
                table: "CaixasRecebimento",
                column: "MoedaIndicadorId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimento_MoedaIndicadorId1",
                table: "CaixasRecebimento",
                column: "MoedaIndicadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimento_VendedorId",
                table: "CaixasRecebimento",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_AdmCartaoId",
                table: "CaixasRecebimentoPgto",
                column: "AdmCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_AdminCartaoId",
                table: "CaixasRecebimentoPgto",
                column: "AdminCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_CaixaRecebimentoId",
                table: "CaixasRecebimentoPgto",
                column: "CaixaRecebimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_CaixaRecebimentoId1",
                table: "CaixasRecebimentoPgto",
                column: "CaixaRecebimentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_MoedaIndicadorId",
                table: "CaixasRecebimentoPgto",
                column: "MoedaIndicadorId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_MoedaIndicadorId1",
                table: "CaixasRecebimentoPgto",
                column: "MoedaIndicadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_TipoPagamentoId",
                table: "CaixasRecebimentoPgto",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasRecebimentoPgto_TipoPagamentoId1",
                table: "CaixasRecebimentoPgto",
                column: "TipoPagamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteClassificacaoId",
                table: "Clientes",
                column: "ClienteClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteClassificacaoId1",
                table: "Clientes",
                column: "ClienteClassificacaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteEscolaridadeId",
                table: "Clientes",
                column: "ClienteEscolaridadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteEscolaridadeId1",
                table: "Clientes",
                column: "ClienteEscolaridadeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteFaixaRendaId",
                table: "Clientes",
                column: "ClienteFaixaRendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteFaixaRendaId1",
                table: "Clientes",
                column: "ClienteFaixaRendaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteProfissaoId",
                table: "Clientes",
                column: "ClienteProfissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteProfissaoId1",
                table: "Clientes",
                column: "ClienteProfissaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteSubTipoId",
                table: "Clientes",
                column: "ClienteSubTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteSubTipoId1",
                table: "Clientes",
                column: "ClienteSubTipoId1");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesSubTipos_ClienteTipoId",
                table: "ClientesSubTipos",
                column: "ClienteTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPagtoParcela_AdminCartaoId",
                table: "CondicoesPagtoParcela",
                column: "AdminCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPagtoParcela_AdminCartaoId1",
                table: "CondicoesPagtoParcela",
                column: "AdminCartaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPagtoParcela_CondicaoPagtoId",
                table: "CondicoesPagtoParcela",
                column: "CondicaoPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPagtoParcela_CondicaoPgtoId",
                table: "CondicoesPagtoParcela",
                column: "CondicaoPgtoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPagtoParcela_TipoPagamentoId",
                table: "CondicoesPagtoParcela",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPagtoParcela_TipoPagtoId",
                table: "CondicoesPagtoParcela",
                column: "TipoPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPgto_AdminCartaoId",
                table: "CondicoesPgto",
                column: "AdminCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPgto_AdminCartaoId1",
                table: "CondicoesPgto",
                column: "AdminCartaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPgto_TipoPagamentoId",
                table: "CondicoesPgto",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicoesPgto_TipoPagtoId",
                table: "CondicoesPgto",
                column: "TipoPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposito_LojaId",
                table: "Deposito",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_DepositoId",
                table: "Estoque",
                column: "DepositoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_ProdutoId",
                table: "Estoque",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_LojasControle_GerenteLojaId",
                table: "LojasControle",
                column: "GerenteLojaId");

            migrationBuilder.CreateIndex(
                name: "IX_LojasControle_LojaId",
                table: "LojasControle",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_LojasControle_LojasId",
                table: "LojasControle",
                column: "LojasId");

            migrationBuilder.CreateIndex(
                name: "IX_LojasHorario_LojaId",
                table: "LojasHorario",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasCondicoesPagto_CondicaoPagtoId",
                table: "OperacoesVendasCondicoesPagto",
                column: "CondicaoPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasCondicoesPagto_CondicaoPgtoId",
                table: "OperacoesVendasCondicoesPagto",
                column: "CondicaoPgtoId");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasCondicoesPagto_OperacaoVendaId",
                table: "OperacoesVendasCondicoesPagto",
                column: "OperacaoVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasCondicoesPagto_OperacaoVendaId1",
                table: "OperacoesVendasCondicoesPagto",
                column: "OperacaoVendaId1");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasTipoCliente_ClienteTipoId",
                table: "OperacoesVendasTipoCliente",
                column: "ClienteTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasTipoCliente_ClienteTipoId1",
                table: "OperacoesVendasTipoCliente",
                column: "ClienteTipoId1");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasTipoCliente_OperacaoVendaId",
                table: "OperacoesVendasTipoCliente",
                column: "OperacaoVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_OperacoesVendasTipoCliente_OperacaoVendaId1",
                table: "OperacoesVendasTipoCliente",
                column: "OperacaoVendaId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_EstoqueId",
                table: "PedidoItens",
                column: "EstoqueId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_EstoqueId1",
                table: "PedidoItens",
                column: "EstoqueId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_MotivoCancelamentoId",
                table: "PedidoItens",
                column: "MotivoCancelamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_MotivoCancelamentoId1",
                table: "PedidoItens",
                column: "MotivoCancelamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_MotivoDescontoId",
                table: "PedidoItens",
                column: "MotivoDescontoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_MotivoDescontoId1",
                table: "PedidoItens",
                column: "MotivoDescontoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_MotivoDevolucaoId",
                table: "PedidoItens",
                column: "MotivoDevolucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_MotivoDevolucaoId1",
                table: "PedidoItens",
                column: "MotivoDevolucaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_PedidoId",
                table: "PedidoItens",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_PedidoId1",
                table: "PedidoItens",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_ProdutoCodigoBarraId",
                table: "PedidoItens",
                column: "ProdutoCodigoBarraId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_ProdutoCodigoBarraId1",
                table: "PedidoItens",
                column: "ProdutoCodigoBarraId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_ProdutoId",
                table: "PedidoItens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_ProdutoId1",
                table: "PedidoItens",
                column: "ProdutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_ProdutoPrecoId",
                table: "PedidoItens",
                column: "ProdutoPrecoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_ProdutoPrecoId1",
                table: "PedidoItens",
                column: "ProdutoPrecoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId1",
                table: "Pedidos",
                column: "ClienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_LojaId",
                table: "Pedidos",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_LojasId",
                table: "Pedidos",
                column: "LojasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MotivoCancelamentoId",
                table: "Pedidos",
                column: "MotivoCancelamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MotivoCancelamentoId1",
                table: "Pedidos",
                column: "MotivoCancelamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MotivoDescontoId",
                table: "Pedidos",
                column: "MotivoDescontoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MotivoDescontoId1",
                table: "Pedidos",
                column: "MotivoDescontoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MotivoDevolucaoId",
                table: "Pedidos",
                column: "MotivoDevolucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MotivoDevolucaoId1",
                table: "Pedidos",
                column: "MotivoDevolucaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TipoPedidoId",
                table: "Pedidos",
                column: "TipoPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TipoPedidoId1",
                table: "Pedidos",
                column: "TipoPedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_MotivoDescontoId",
                table: "PedidosDesconto",
                column: "MotivoDescontoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_MotivoDescontoId1",
                table: "PedidosDesconto",
                column: "MotivoDescontoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoId",
                table: "PedidosDesconto",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoId1",
                table: "PedidosDesconto",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoItemId",
                table: "PedidosDesconto",
                column: "PedidoItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoItemId1",
                table: "PedidosDesconto",
                column: "PedidoItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoPagtoId",
                table: "PedidosDesconto",
                column: "PedidoPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoPgtoId",
                table: "PedidosDesconto",
                column: "PedidoPgtoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoPromocaoId",
                table: "PedidosDesconto",
                column: "PedidoPromocaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_PedidoPromocaoId1",
                table: "PedidosDesconto",
                column: "PedidoPromocaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_VendedorId",
                table: "PedidosDesconto",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDesconto_VendedorId1",
                table: "PedidosDesconto",
                column: "VendedorId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosEntregas_PedidoId",
                table: "PedidosEntregas",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosEntregas_PedidoId1",
                table: "PedidosEntregas",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosEntregas_TransportadoraId",
                table: "PedidosEntregas",
                column: "TransportadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_AdminCartaoId",
                table: "PedidosPgto",
                column: "AdminCartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_AdminCartaoId1",
                table: "PedidosPgto",
                column: "AdminCartaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_CondicaoPagtoId",
                table: "PedidosPgto",
                column: "CondicaoPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_CondicaoPagtoId1",
                table: "PedidosPgto",
                column: "CondicaoPagtoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_MoedaIndicadorId",
                table: "PedidosPgto",
                column: "MoedaIndicadorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_MoedaIndicadorId1",
                table: "PedidosPgto",
                column: "MoedaIndicadorId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_PedidoId",
                table: "PedidosPgto",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_PedidoId1",
                table: "PedidosPgto",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_TipoPagamentoId",
                table: "PedidosPgto",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPgto_TipoPagtoId",
                table: "PedidosPgto",
                column: "TipoPagtoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPromocao_PedidoId",
                table: "PedidosPromocao",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPromocao_PedidoId1",
                table: "PedidosPromocao",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosVendedor_PedidoId",
                table: "PedidosVendedor",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosVendedor_PedidoId1",
                table: "PedidosVendedor",
                column: "PedidoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosVendedor_VendedorId",
                table: "PedidosVendedor",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosVendedor_VendedorId1",
                table: "PedidosVendedor",
                column: "VendedorId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoAtributos_ProdutoAtributoDefinicaoId",
                table: "ProdutoAtributos",
                column: "ProdutoAtributoDefinicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCatalogo_ProdutoAtributoId",
                table: "ProdutoCatalogo",
                column: "ProdutoAtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCatalogo_ProdutoId",
                table: "ProdutoCatalogo",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCodigoBarra_ProdutoId",
                table: "ProdutoCodigoBarra",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCorBasica_ProdutoAtributoId",
                table: "ProdutoCorBasica",
                column: "ProdutoAtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCorBasica_ProdutoId",
                table: "ProdutoCorBasica",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoKits_KitId",
                table: "ProdutoKits",
                column: "KitId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoKits_KitId1",
                table: "ProdutoKits",
                column: "KitId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoKits_ProdutoId",
                table: "ProdutoKits",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoLookComposicoes_ProdutoAtributoId",
                table: "ProdutoLookComposicoes",
                column: "ProdutoAtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoLookComposicoes_ProdutoId",
                table: "ProdutoLookComposicoes",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoPrecos_ProdutoId",
                table: "ProdutoPrecos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTributos_ProdutoId",
                table: "ProdutoTributos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_PromocaoTipoOferta_PromocaoId",
                table: "PromocaoTipoOferta",
                column: "PromocaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PromocaoTipoOferta_PromocaoId1",
                table: "PromocaoTipoOferta",
                column: "PromocaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PromocaoTipoOferta_TipoOfertaId",
                table: "PromocaoTipoOferta",
                column: "TipoOfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_PromocaoTipoOferta_TipoOfertaId1",
                table: "PromocaoTipoOferta",
                column: "TipoOfertaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Promocoes_PromocaoGrupoId",
                table: "Promocoes",
                column: "PromocaoGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Promocoes_PromocaoGrupoId1",
                table: "Promocoes",
                column: "PromocaoGrupoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Promocoes_TipoOperacaoVendaId",
                table: "Promocoes",
                column: "TipoOperacaoVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Promocoes_TipoOperacaoVendaId1",
                table: "Promocoes",
                column: "TipoOperacaoVendaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Promocoes_TipoPagamentoId",
                table: "Promocoes",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Promocoes_TipoPagamentoId1",
                table: "Promocoes",
                column: "TipoPagamentoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Terminal_LojaId",
                table: "Terminal",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Terminal_LojasId",
                table: "Terminal",
                column: "LojasId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_LojaId",
                table: "Vendedores",
                column: "LojaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtigoBrinde");

            migrationBuilder.DropTable(
                name: "CaixasFechamento");

            migrationBuilder.DropTable(
                name: "CaixasRecebimentoPgto");

            migrationBuilder.DropTable(
                name: "CondicoesPagtoParcela");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "LojasControle");

            migrationBuilder.DropTable(
                name: "LojasHorario");

            migrationBuilder.DropTable(
                name: "OperacoesVendasCondicoesPagto");

            migrationBuilder.DropTable(
                name: "OperacoesVendasTipoCliente");

            migrationBuilder.DropTable(
                name: "PedidosDesconto");

            migrationBuilder.DropTable(
                name: "PedidosEntregas");

            migrationBuilder.DropTable(
                name: "PedidosVendedor");

            migrationBuilder.DropTable(
                name: "ProdutoCatalogo");

            migrationBuilder.DropTable(
                name: "ProdutoCorBasica");

            migrationBuilder.DropTable(
                name: "ProdutoKits");

            migrationBuilder.DropTable(
                name: "ProdutoLookComposicoes");

            migrationBuilder.DropTable(
                name: "ProdutoTributos");

            migrationBuilder.DropTable(
                name: "ProgramasFidelidade");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "PromocaoTipoOferta");

            migrationBuilder.DropTable(
                name: "CaixasRecebimento");

            migrationBuilder.DropTable(
                name: "OperacoesVenda");

            migrationBuilder.DropTable(
                name: "PedidoItens");

            migrationBuilder.DropTable(
                name: "PedidosPgto");

            migrationBuilder.DropTable(
                name: "PedidosPromocao");

            migrationBuilder.DropTable(
                name: "Transportadoras");

            migrationBuilder.DropTable(
                name: "Kit");

            migrationBuilder.DropTable(
                name: "ProdutoAtributos");

            migrationBuilder.DropTable(
                name: "Promocoes");

            migrationBuilder.DropTable(
                name: "TiposOfertas");

            migrationBuilder.DropTable(
                name: "CaixasLancamento");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "ProdutoCodigoBarra");

            migrationBuilder.DropTable(
                name: "ProdutoPrecos");

            migrationBuilder.DropTable(
                name: "CondicoesPgto");

            migrationBuilder.DropTable(
                name: "MoedasIndicador");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "ProdutoAtributoDefinicoes");

            migrationBuilder.DropTable(
                name: "PromocoesGrupo");

            migrationBuilder.DropTable(
                name: "TiposOperacoesVendas");

            migrationBuilder.DropTable(
                name: "CaixasControle");

            migrationBuilder.DropTable(
                name: "TiposLancamento");

            migrationBuilder.DropTable(
                name: "Deposito");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "AdminsCartao");

            migrationBuilder.DropTable(
                name: "TiposPagamento");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "MotivosCancelamento");

            migrationBuilder.DropTable(
                name: "MotivosDesconto");

            migrationBuilder.DropTable(
                name: "MotivosDevolucao");

            migrationBuilder.DropTable(
                name: "TiposPedido");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Terminal");

            migrationBuilder.DropTable(
                name: "UnidadesMedida");

            migrationBuilder.DropTable(
                name: "CredenciadorasCartao");

            migrationBuilder.DropTable(
                name: "ClientesClassificacoe");

            migrationBuilder.DropTable(
                name: "ClientesEscolaridade");

            migrationBuilder.DropTable(
                name: "ClientesFaixaRenda");

            migrationBuilder.DropTable(
                name: "ClientesProfissoes");

            migrationBuilder.DropTable(
                name: "ClientesSubTipos");

            migrationBuilder.DropTable(
                name: "Lojas");

            migrationBuilder.DropTable(
                name: "ClientesTipos");
        }
    }
}
