using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoCatalogoService : IProdutoCatalogoService
{
    private readonly IProdutoCatalogoRepository _produtoCatalogoRepository;

    public ProdutoCatalogoService(IProdutoCatalogoRepository produtoCatalogoRepository)
    {
        _produtoCatalogoRepository = produtoCatalogoRepository;
    }

    public async Task AddAsync(ProdutoCatalogo produtoCatalogo)
    {
        await _produtoCatalogoRepository.AddAsync(produtoCatalogo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoCatalogoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoCatalogo>> GetAllAsync()
    {
        return await _produtoCatalogoRepository.GetAllAsync();
    }

    public async Task<ProdutoCatalogo?> GetByIdAsync(Guid id)
    {
        return await _produtoCatalogoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoCatalogo produtoCatalogo)
    {
        await _produtoCatalogoRepository.UpdateAsync(produtoCatalogo);
    }
}
