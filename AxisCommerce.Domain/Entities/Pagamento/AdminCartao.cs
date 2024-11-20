using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pagamento;

public class AdminCartao
{
    public Guid Id { get; set; }
    public Guid CredenciadoraCartaoId { get; set; }
    [JsonIgnore]
    public CredenciadoraCartao? CredenciadoraCartao { get; set; }
    public string DescAdminCartao { get; set; } = string.Empty;
    public string TipoCartao { get; set; } = string.Empty;
    public int ParcelaJurosLoja { get; set; } = 0;
    public int ParcelaJurosAdminCartao { get; set; } = 0;
    public double TaxaJurosParcelamento { get; set; } = 0;
    public int DiasPrimeiraParcela { get; set; } = 0;
    public bool IndicaCarteiraDigital { get; set; } = false;
    public bool Inativo { get; set; } = false;

    [JsonIgnore]
    public ICollection<CaixaRecebimentoPgto>? CaixasRecebimentoPgto { get; set; }
    [JsonIgnore]
    public ICollection<CondicaoPagto>? CondicaoPagtos { get; set; }
    [JsonIgnore]
    public ICollection<CondicaoPagtoParcela>? CondicaoPagtoParcelas { get; set; }
    [JsonIgnore]
    public ICollection<PedidoPagto>? PedidoPagos { get; set; }
}
