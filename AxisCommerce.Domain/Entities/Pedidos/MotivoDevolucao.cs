using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pedidos;

public class MotivoDevolucao
{
    public Guid Id { get; set; }
    public string DescMotivoDevolucao { get; set; } = string.Empty;
    public bool AprovacaoGerente { get; set; } = false;
    public bool IndicaDevoculaoItem { get; set; } = false;
    public bool Inativo { get; set; } = false;

    [JsonIgnore]
    public ICollection<Pedido>? Pedidos { get; set; }
    [JsonIgnore]
    public ICollection<PedidoItem>? PedidoItens { get; set; }
}
