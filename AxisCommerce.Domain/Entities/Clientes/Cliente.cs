using AxisCommerce.Domain.Entities.Pedidos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Clientes;

public class Cliente
{
    public Guid Id { get; set; }
    public string? NomeCliente { get; set; }
    public string? CPFCliente { get; set; }
    public string? CNPJCliente { get; set; }
    public string? TelefoneCliente { get; set; }
    public string? EmailCliente { get; set; }
    public string? EnderecoCliente { get; set; }
    public string? CEPCliente { get; set; }
    public string? UFCliente { get; set; }
    public Guid? ClienteEscolaridadeId { get; set; }
    [JsonIgnore]
    public ClienteEscolaridade? ClienteEscolaridade { get; set; }
    public Guid? ClienteFaixaRendaId { get; set; }
    [JsonIgnore]
    public ClienteFaixaRenda? ClienteFaixaRenda { get; set; }
    public Guid? ClienteProfissaoId { get; set; }
    [JsonIgnore]
    public ClienteProfissao? ClienteProfissao { get; set; }
    public Guid? ClienteSubTipoId { get; set; }
    [JsonIgnore]
    public ClienteSubTipo? ClienteSubTipo { get; set; }
    public Guid? ClienteClassificacaoId { get; set; }
    [JsonIgnore]
    public ClienteClassificacao? ClienteClassificacao { get; set; }

    [JsonIgnore]
    public ICollection<Pedido>? Pedidos { get; set; }
}
