namespace AxisCommerce.Domain.Entities.Autenticacao
{
    public enum UsuarioTipo
    {
        Admin = 1,
        Gerente = 2,
        Vendedor = 3
    }

    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public UsuarioTipo Tipo { get; set; }
    }
}
