using AxisCommerce.Domain.Entities.Caixa;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Pagamento;

public class CredenciadoraCartao
{
    public Guid Id { get; set; }
    public string CodCredenciadoraCartao { get; set; } = string.Empty;
    public string RazaoSocial { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<AdminCartao>? AdminsCartao { get; set; }
}
