using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class PedidoEntrega
{
    public Guid Id { get; set; }
    public Guid PedidoId { get; set; }
    [JsonIgnore]
    public Pedido? Pedido { get; set; }
    public string EnderecoEntrega { get; set; } = string.Empty;
    public string EnderecoCobranca { get; set; } = string.Empty;
    public string PeriodoEntrega { get; set; } = string.Empty;
    public double ValorFrete { get; set; } = 0;
    public double DescontoFrete { get; set; } = 0;
    public double ValorSeguro { get; set; } = 0;
    public int Peso { get; set; } = 0;
    public string MensagemCartao { get; set; } = string.Empty;
    public string ObsEntrega { get; set; } = string.Empty;
    public int Volume { get; set; } = 0;
    public string OpcaoEntrega { get; set;} = string.Empty;
    public int SeqEntrega { get; set; } = 0;
    public double TaxaManuseio { get; set; } = 0;
    public Guid TransportadoraId { get; set; } = Guid.Empty;
}
