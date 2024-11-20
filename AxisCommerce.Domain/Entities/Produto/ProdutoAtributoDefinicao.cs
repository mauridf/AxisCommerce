namespace AxisCommerce.Domain.Entities.Produtos;

public class ProdutoAtributoDefinicao
{
    public Guid Id { get; set; }
    public Guid? IdSuperior { get; set; }
    public string DescAtributoDefinição { get; set; } = string.Empty;
    public string DescResumidaAtributo { get; set; } = string.Empty;
}
