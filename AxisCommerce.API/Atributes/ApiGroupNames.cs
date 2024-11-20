using System.Reflection;

namespace AxisCommerce.API.Atributes;

public enum ApiGroupNames
{
    [GroupInfo(Title = "1 - Autenticação", Description = "AxisCommerce - Autenticação")]
    Autenticacao,
    [GroupInfo(Title = "2 - Caixa", Description = "AxisCommerce - Caixa")]
    Caixa,
    [GroupInfo(Title = "3 - Cliente", Description = "AxisCommerce - Cliente")]
    Cliente,
    [GroupInfo(Title = "4 - Loja", Description = "AxisCommerce - Loja")]
    Loja,
    [GroupInfo(Title = "5 - Pagamento", Description = "AxisCommerce - Pagamento")]
    Pagamento,
    [GroupInfo(Title = "6 - Pedido", Description = "AxisCommerce - Pedido")]
    Pedido,
    [GroupInfo(Title = "7 - Produto", Description = "AxisCommerce - Produto")]
    Produto,
    [GroupInfo(Title = "8 - Vendas", Description = "AxisCommerce - Vendas")]
    Venda,
}
