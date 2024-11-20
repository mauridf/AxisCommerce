using AxisCommerce.Domain.Entities.Autenticacao;
using System.Threading.Tasks;

namespace AxisCommerce.Domain.Interfaces.Autenticacao;

public interface IUsuarioService
{
    Task<Usuario> RegistrarUsuarioAsync(Usuario usuario, string senha);
    Task<string> LoginAsync(string email, string senha);
}
