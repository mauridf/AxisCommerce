using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoAtributoDefinicaoService : IProdutoAtributoDefinicaoService
{
    private readonly IProdutoAtributoDefinicaoRepository _produtoAtributoDefinicaoRepository;

    public ProdutoAtributoDefinicaoService(IProdutoAtributoDefinicaoRepository produtoAtributoDefinicaoRepository)
    {
        _produtoAtributoDefinicaoRepository = produtoAtributoDefinicaoRepository;
    }

    public async Task AddAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao)
    {
        await _produtoAtributoDefinicaoRepository.AddAsync(produtoAtributoDefinicao);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoAtributoDefinicaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoAtributoDefinicao>> GetAllAsync()
    {
        return await _produtoAtributoDefinicaoRepository.GetAllAsync();
    }

    public async Task<ProdutoAtributoDefinicao?> GetByIdAsync(Guid id)
    {
        return await _produtoAtributoDefinicaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoAtributoDefinicao produtoAtributoDefinicao)
    {
        await _produtoAtributoDefinicaoRepository.UpdateAsync(produtoAtributoDefinicao);
    }
}
