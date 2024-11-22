using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class ProdutoCorBasicaService : IProdutoCorBasicaService
{
    private readonly IProdutoCorBasicaRepository _produtoCorBasicaRepository;

    public ProdutoCorBasicaService(IProdutoCorBasicaRepository produtoCorBasicaRepository)
    {
        _produtoCorBasicaRepository = produtoCorBasicaRepository;
    }

    public async Task AddAsync(ProdutoCorBasica produtoCorBasica)
    {
        await _produtoCorBasicaRepository.AddAsync(produtoCorBasica);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _produtoCorBasicaRepository.DeleteAsync(id);
    }

    public Task<IEnumerable<ProdutoCorBasica>> GetAllAsync()
    {
        return _produtoCorBasicaRepository.GetAllAsync();
    }

    public Task<ProdutoCorBasica?> GetByIdAsync(Guid id)
    {
        return _produtoCorBasicaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(ProdutoCorBasica produtoCorBasica)
    {
        await _produtoCorBasicaRepository.UpdateAsync(produtoCorBasica);
    }
}
