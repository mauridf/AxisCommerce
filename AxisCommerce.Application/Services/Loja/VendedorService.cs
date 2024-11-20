using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;

namespace AxisCommerce.Application.Services.Lojas;

public class VendedorService : IVendedorService
{
    private readonly IVendedorRepository _vendedorRepository;

    public VendedorService(IVendedorRepository vendedorRepository)
    {
        _vendedorRepository = vendedorRepository;
    }

    public async Task AddAsync(Vendedor vendedor)
    {
        await _vendedorRepository.AddAsync(vendedor);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _vendedorRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Vendedor>> GetAllAsync()
    {
        return await _vendedorRepository.GetAllAsync();
    }

    public async Task<Vendedor?> GetByCodVendedor(string codigoVendedor)
    {
        return await _vendedorRepository.GetByCodVendedor(codigoVendedor);
    }

    public async Task<Vendedor?> GetByIdAsync(Guid id)
    {
        return await _vendedorRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Vendedor>> GetGerentesAsync()
    {
        return await _vendedorRepository.GetGerentesAsync();
    }

    public async Task<IEnumerable<Vendedor>> GetOperadoresAsync()
    {
        return await _vendedorRepository.GetOperadoresAsync();
    }

    public async Task UpdateAsync(Vendedor vendedor)
    {
        await _vendedorRepository.UpdateAsync(vendedor);
    }
}
