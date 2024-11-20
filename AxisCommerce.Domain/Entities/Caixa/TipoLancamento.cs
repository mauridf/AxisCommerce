using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Caixa;

public class TipoLancamento
{
    public Guid Id { get; set; }
    public string? DescTipoLancamento { get; set; }
    public bool IndicaSaida { get; set; } = false;
    public string DescNaoFiscal { get; set; } = string.Empty;
    public bool Inativo { get; set; } = false;

    [JsonIgnore]
    public ICollection<CaixaLancamento>? CaixasLancamento { get; set; }
}
