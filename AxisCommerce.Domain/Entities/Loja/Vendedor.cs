using AxisCommerce.Domain.Entities.Caixa;
using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Loja;

public class Vendedor
{
    public Guid Id { get; set; }
    public Guid LojaId { get; set; }
    [JsonIgnore]
    public Lojas? Loja { get; set; }
    public string CodVendedor { get; set; } = string.Empty;
    public string NomeVendedor { get; set; } = string.Empty;
    public bool IndicaGerente { get; set; }
    public bool IndicaOperadorCaixa { get; set; }
    public string? Apelido { get; set; } = string.Empty;
    public bool Inativo { get; set; } = false;
    public string CPF { get; set; } = string.Empty;
    public DateOnly DataNascimento { get; set; }
    public DateTime DataAtivacao { get; set; }
    public DateTime? DataDesativacao { get; set; }
    public string LoginVendedor { get; set; } = string.Empty;
    public string SenhaVendedor { get; set; } = string.Empty;
    public Guid? LojasId { get; set; }

    [JsonIgnore]
    public ICollection<CaixaControle>? CaixasControle { get; set; }
    [JsonIgnore]
    public ICollection<CaixaRecebimento>? CaixasRecebimento { get; set; }
    [JsonIgnore]
    public ICollection<PedidoDesconto>? PedidoDescontos { get; set; }
    [JsonIgnore]
    public ICollection<PedidoVendedor>? PedidoVendedor { get; set; }
}
