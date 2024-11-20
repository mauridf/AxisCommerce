using AxisCommerce.Domain.Entities.Pagamento;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class PedidoPagto
{
    public Guid Id { get; set; }
    public Guid PedidoId { get; set; }
    [JsonIgnore]
    public Pedido? Pedido { get; set; }
    public Guid TipoPagtoId { get; set; }
    [JsonIgnore]
    public TipoPagamento? TipoPagamento { get; set; }
    public Guid AdminCartaoId { get; set; }
    [JsonIgnore]
    public AdminCartao? AdminCartao { get; set; }
    public Guid MoedaIndicadorId { get; set; }
    [JsonIgnore]
    public MoedaIndicador? MoedaIndicador { get; set; }
    public int Parcela { get; set; } = 0;
    public double Valor { get; set; } = 0;
    public DateOnly Vencimento { get; set; }
    public string Banco { get; set; } = string.Empty;
    public string Agencia { get; set; } = string.Empty;
    public string ContaCorrente { get; set; } = string.Empty;
    public int ParcelasCartao { get; set; } = 0;
    public Guid CondicaoPagtoId { get; set; }
    [JsonIgnore]
    public CondicaoPagto? CondicaoPagto { get; set; }
    public string BinCartao { get; set; } = string.Empty;
    public string UltimosQuatroDigitosCartao { get; set; } = string.Empty;
    public DateOnly ValidadeCartao { get; set; } = DateOnly.MinValue;
    public string NomeClienteCartao { get; set; } = string.Empty;
    public double Troco { get; set; } = 0;

    [JsonIgnore]
    public ICollection<PedidoDesconto>? PedidoDescontos { get; set; }
}
