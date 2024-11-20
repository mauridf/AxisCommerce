using AxisCommerce.Domain.Entities.Autenticacao;
using AxisCommerce.Domain.Interfaces.Autenticacao;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AxisCommerce.Infrastructure.Services.Autenticacao
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IConfiguration _configuration;

        public UsuarioService(IUsuarioRepository usuarioRepository, IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository;
            _configuration = configuration;
        }

        public async Task<Usuario> RegistrarUsuarioAsync(Usuario usuario, string senha)
        {
            // Gerar hash da senha (implementação simples de exemplo)
            usuario.SenhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

            return await _usuarioRepository.AddAsync(usuario);
        }

        public async Task<string> LoginAsync(string email, string senha)
        {
            var usuario = await _usuarioRepository.GetByEmailAsync(email);
            if (usuario == null || !BCrypt.Net.BCrypt.Verify(senha, usuario.SenhaHash))
            {
                return null; // Usuário ou senha inválida
            }

            // Gerar token JWT
            var tokenHandler = new JwtSecurityTokenHandler();
            var secretKey = _configuration["JwtSettings:SecretKey"];
            var key = Encoding.UTF8.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.Role, usuario.Tipo.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                Issuer = _configuration["JwtSettings:Issuer"],
                Audience = _configuration["JwtSettings:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
