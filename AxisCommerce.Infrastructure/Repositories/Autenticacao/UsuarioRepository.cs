using AxisCommerce.Domain.Entities.Autenticacao;
using AxisCommerce.Domain.Interfaces.Autenticacao;
using AxisCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AxisCommerce.Infrastructure.Repositories.Autenticacao;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly ApplicationDbContext _context;

    public UsuarioRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Usuario> AddAsync(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public async Task<Usuario> GetByEmailAsync(string email)
    {
        return await _context.Usuarios.SingleOrDefaultAsync(u => u.Email == email);
    }

    public async Task DeleteAsync(string email)
    {
        var usuario = await GetByEmailAsync(email);
        if (usuario != null)
        {
            _context.Set<Usuario>().Remove(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
