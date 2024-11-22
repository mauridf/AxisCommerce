using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoAtributoService : IProdutoAtributoService
{
    private readonly IProdutoAtributoRepository _produtoAtributoRepository;

    public ProdutoAtributoService(IProdutoAtributoRepository produtoAtributoRepository)
    {
        _produtoAtributoRepository = produtoAtributoRepository;
    }

    public async Task AddAsync(ProdutoAtributo produtoAtributo)
    {
        await _produtoAtributoRepository.AddAsync(produtoAtributo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoAtributoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoAtributo>> GetAllAsync()
    {
        return await _produtoAtributoRepository.GetAllAsync();
    }

    public async Task<ProdutoAtributo?> GetByIdAsync(Guid id)
    {
        return await _produtoAtributoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoAtributo produtoAtributo)
    {
        await _produtoAtributoRepository.UpdateAsync(produtoAtributo);
    }
}
