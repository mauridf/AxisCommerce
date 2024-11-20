using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class OperacaoVenda
{
    public Guid Id { get; set; }
    public string CodOperacaoVenda { get; set; } = string.Empty;
    public string DescOperacaoVenda { get; set; } = string.Empty;
    public string DescNaturezaOperacao { get; set; } = string.Empty;
    public DateOnly DataAtivar { get; set; }
    public DateOnly? DataDesativar { get; set; }
    public int LimiteDesconto { get; set; } = 0;
    public int LimiteDescontoGerente { get; set; } = 0;

    [JsonIgnore]
    public ICollection<OperacaoVendaCondicaoPgto>? OperacaoVendaCondicaoPgtos { get; set; }
    [JsonIgnore]
    public ICollection<OperacaoVendaTipoCliente>? OperacaoVendaTipoClientes { get; set; }
}
