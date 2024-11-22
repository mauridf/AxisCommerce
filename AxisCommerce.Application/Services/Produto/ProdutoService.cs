using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task AddAsync(Produto produto)
    {
        await _produtoRepository.AddAsync(produto);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _produtoRepository.GetAllAsync();
    }

    public async Task<Produto?> GetByIdAsync(Guid id)
    {
        return await _produtoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Produto produto)
    {
        await _produtoRepository.UpdateAsync(produto);
    }
}
