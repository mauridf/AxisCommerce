using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class MotivoCancelamento
{
    public Guid Id { get; set; }
    public string DescMotivoCancelamento { get; set; } = string.Empty;
    public bool IndicaCancelamentoItem { get; set; } = false;
    public bool Inativo { get; set; } = false;

    [JsonIgnore]
    public ICollection<Pedido>? Pedidos { get; set; }
    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
}
