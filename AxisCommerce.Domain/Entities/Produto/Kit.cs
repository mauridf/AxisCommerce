using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Produtos;

public class Kit
{
    public Guid Id { get; set; }
    public string DescKit { get; set; } = string.Empty;
    public int Qtdd { get; set; } = 0;
    public double PorcAbsorcaoDesconto { get; set; } = 0;

    [JsonIgnore]
    public ICollection<ProdutoKit>? ProdutoKits { get; set; }
}
