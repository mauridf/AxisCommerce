using AxisCommerce.API.Atributes;
using AxisCommerce.Domain.Entities.Autenticacao;
using AxisCommerce.Domain.Interfaces.Autenticacao;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Autenticacao
{
    [ApiController]
    [ApiVersion("1.0"), ApiGroup(ApiGroupNames.Autenticacao)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] Usuario usuario, [FromQuery] string senha)
        {
            var novoUsuario = await _usuarioService.RegistrarUsuarioAsync(usuario, senha);
            return Ok(novoUsuario);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var token = await _usuarioService.LoginAsync(loginRequest.Email, loginRequest.Senha);
            if (token == null)
                return Unauthorized("Usuário ou senha inválidos.");

            return Ok(new { Token = token });
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
