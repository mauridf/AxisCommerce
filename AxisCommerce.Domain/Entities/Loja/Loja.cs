using AxisCommerce.Domain.Entities.Pedidos;
using AxisCommerce.Domain.Entities.Produtos;
using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Loja;

public class Lojas
{
    public Guid Id { get; set; }
    public string CodLoja { get; set; } = string.Empty;
    public string DescLoja { get; set; } = string.Empty;
    public string? NomeFantasia { get; set; }
    public string? RazaoSocial { get; set; }
    public int IndicaPessoaJuridicaFisica { get; set; } = 1; // 1 - PJ e 2 = PF
    public string CNPJ_CPF { get; set; } = string.Empty;
    public string? InscEstadual { get; set; } = string.Empty;
    public string? InscMunicipal { get; set; } = string.Empty;
    public string? InscSuframa { get; set; } = string.Empty;
    public int? TipoLogradouro { get; set; }
    public string? Logradouro { get; set; } = string.Empty;
    public string? Numero { get; set; } = string.Empty;
    public string? Complemento { get; set; } = string.Empty;
    public string? Bairro { get; set; } = string.Empty;
    public string? Cidade { get; set; } = string.Empty;
    public string? UF { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string? Pais { get; set; } = "Brasil";
    public string? CEP { get; set; } = string.Empty;
    public bool Inativo { get; set; } = false;
    public DateOnly DataAbertura { get; set; }
    public DateOnly? DataFechamento { get; set; }
    public string? DDD { get; set; } = string.Empty;
    public string? Telefone { get; set; } = string.Empty;

    [JsonIgnore]
    public ICollection<Deposito>? Depositos { get; set; }
    [JsonIgnore]
    public ICollection<Vendedor>? Vendedores { get; set; }
    [JsonIgnore]
    public ICollection<Terminal>? Terminais { get; set; }
    [JsonIgnore]
    public ICollection<Pedido>? Pedidos { get; set; }
    [JsonIgnore]
    public ICollection<LojaControle>? LojaControle { get; set; }
}
