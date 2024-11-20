namespace AxisCommerce.Domain.Entities.Loja;

public class Fornecedor
{
    public Guid Id { get; set; }
    public string CNPJ { get; set; } = string.Empty;
    public string RazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Complemento { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Municipio { get; set; } = string.Empty;
    public string UF { get; set; } = string.Empty;
    public string Pais { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public string DDD { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
