using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoLookComposicaoService : IProdutoLookComposicaoService
{
    private readonly IProdutoLookComposicaoRepository _produtoLookComposicaoRepository;

    public ProdutoLookComposicaoService(IProdutoLookComposicaoRepository produtoLookComposicaoRepository)
    {
        _produtoLookComposicaoRepository = produtoLookComposicaoRepository;
    }

    public async Task AddAsync(ProdutoLookComposicao produtoLookComposicao)
    {
        await _produtoLookComposicaoRepository.AddAsync(produtoLookComposicao);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoLookComposicaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoLookComposicao>> GetAllAsync()
    {
        return await _produtoLookComposicaoRepository.GetAllAsync();
    }

    public async Task<ProdutoLookComposicao?> GetByIdAsync(Guid id)
    {
        return await _produtoLookComposicaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoLookComposicao produtoLookComposicao)
    {
        await _produtoLookComposicaoRepository.UpdateAsync(produtoLookComposicao);
    }
}
