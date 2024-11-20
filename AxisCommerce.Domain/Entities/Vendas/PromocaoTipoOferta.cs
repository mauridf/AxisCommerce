using AxisCommerce.Domain.Entities.Produtos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class PromocaoTipoOferta
{
    public Guid Id { get; set; }
    public Guid PromocaoId { get; set; }
    [JsonIgnore]
    public Promocao? Promocao { get; set; }
    public Guid TipoOfertaId { get; set; }
    [JsonIgnore]
    public TipoOferta? TipoOferta { get; set; }
    public double ValorMinimo { get; set; } = 0;
    public int QtdBrindCumpom { get; set; } = 0;
    public int QdtMinima { get; set; } = 0;
    public double ValorDesconto { get; set; } = 0;
    public int PorcentagemDesconto { get; set; } = 0;
    public int QtdMaximaPorCliente { get; set; } = 0;
    public string TextoComprovante { get; set; } = string.Empty;
    public string MsgInternet { get; set; } = string.Empty;
    public string MsgOperador { get; set; } = string.Empty;
    public string DescBeneficio { get; set; } = string.Empty;
    public string DescRegra {  get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<ArtigoBrinde>? ArtigoBrinde { get; set; }
}
