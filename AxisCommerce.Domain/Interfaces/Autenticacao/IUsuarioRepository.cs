using AxisCommerce.Domain.Entities.Autenticacao;

namespace AxisCommerce.Domain.Interfaces.Autenticacao;

public interface IUsuarioRepository
{
    Task<Usuario> AddAsync(Usuario usuario);
    Task DeleteAsync(string email);
    Task<Usuario> GetByEmailAsync(string email);
}