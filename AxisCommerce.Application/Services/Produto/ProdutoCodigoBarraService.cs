using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoCodigoBarraService : IProdutoCodigoBarraService
{
    private readonly IProdutoCodigoBarraRepository _produtoCodigoBarraRepository;

    public ProdutoCodigoBarraService(IProdutoCodigoBarraRepository produtoCodigoBarraRepository)
    {
        _produtoCodigoBarraRepository = produtoCodigoBarraRepository;
    }

    public async Task AddAsync(ProdutoCodigoBarra produtoCodigoBarra)
    {
        await _produtoCodigoBarraRepository.AddAsync(produtoCodigoBarra);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoCodigoBarraRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ProdutoCodigoBarra>> GetAllAsync()
    {
        return await _produtoCodigoBarraRepository.GetAllAsync();
    }

    public async Task<ProdutoCodigoBarra?> GetByIdAsync(Guid id)
    {
        return await _produtoCodigoBarraRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoCodigoBarra produtoCodigoBarra)
    {
        await _produtoCodigoBarraRepository.UpdateAsync(produtoCodigoBarra);
    }
}
