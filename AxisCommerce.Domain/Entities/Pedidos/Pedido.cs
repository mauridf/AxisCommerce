using AxisCommerce.Domain.Entities.Clientes;
using AxisCommerce.Domain.Entities.Loja;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class Pedido
{
    public Guid Id { get; set; }
    public Guid LojaId { get; set; }
    [JsonIgnore]
    public Lojas? Loja { get; set; }
    public string CodLoja { get; set; } = string.Empty;
    public Guid ClienteId { get; set; }
    [JsonIgnore]
    public Cliente? Cliente { get; set; }
    public string NumeroPedido { get; set; } = string.Empty;
    public string IdentificacaoPedido { get; set; } = string.Empty;
    public DateOnly DataPedido { get; set; }
    public Guid TipoPedidoId { get; set; }
    [JsonIgnore]
    public TipoPedido? TipoPedido { get; set; }
    public int StatusPedido { get; set; } = 30;
    public int QtddTotal { get; set; } = 0;
    public double ValorTotalBruto { get; set; } = 0;
    public double ValorDesconto { get; set; } = 0;
    public double ValorTotalLiquido { get; set; } = 0;
    public Guid MotivoCancelamentoId { get; set; }
    [JsonIgnore]
    public MotivoCancelamento? MotivoCancelamento { get; set; }
    public Guid MotivoDescontoId { get; set; }
    [JsonIgnore]
    public MotivoDesconto? MotivoDesconto { get; set; }
    public Guid MotivoDevolucaoId { get; set; }
    [JsonIgnore]
    public MotivoDevolucao? MotivoDevolucao { get; set; }
    public int OrigemPedido { get; set; } = 0;
    public int TipoEntrega { get; set; } = 0;
    public TimeOnly HoraInicioPedido { get; set; }
    public DateTime? DataHoraFimPedido { get; set; }
    public string? VoucherPromocional { get; set; }
    public bool IndicaFidelidade { get; set; } = false;
    public int FidelidadePontosUtilizados { get; set; } = 0;

    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
    [JsonIgnore]
    public ICollection<PedidoEntrega>? PedidoEntregas { get; set; }
    [JsonIgnore]
    public ICollection<PedidoDesconto>? PedidoDescontos { get; set; }
    [JsonIgnore]
    public ICollection<PedidoPromocao>? PedidoPromocoes { get; set; }
    [JsonIgnore]
    public ICollection<PedidoVendedor>? PedidoVendedor { get; set; }
    [JsonIgnore]
    public ICollection<PedidoPagto>? PedidoPagos { get; set; }
}
