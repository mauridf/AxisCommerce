using AxisCommerce.Domain.Entities.Pagamento;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Vendas;

public class Promocao
{
    public Guid Id { get; set; }
    public Guid PromocaoGrupoId { get; set; }
    [JsonIgnore]
    public PromocaoGrupo? PromocaoGrupo { get; set; }
    public DateOnly DataCadastro { get; set; }
    public string DescPromocao { get; set; } = string.Empty;
    public int Status { get; set; } = 0;
    public DateOnly DataAtivar { get; set; }
    public DateOnly? DataDesativar { get; set; }
    public Guid TipoPagamentoId { get; set; }
    [JsonIgnore]
    public TipoPagamento? TipoPagamento { get; set; }
    public Guid TipoOperacaoVendaId { get; set; }
    [JsonIgnore]
    public TipoOperacaoVenda? TipoOperacaoVenda { get; set; }
    public bool Inativo { get; set; } = false;
    public int QtddLimite { get; set; } = 0;
    public string URL { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<PromocaoTipoOferta>? PromocaoTipoOferta { get; set; }
}
