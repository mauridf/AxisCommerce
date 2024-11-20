using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using AxisCommerce.Domain.Interfaces.Loja;

namespace AxisCommerce.Application.Services.Lojas;

public class FornecedorService : IFornecedorService
{
    private readonly IFornecedorRepository _fornecedorRepository;

    public FornecedorService(IFornecedorRepository fornecedorRepository)
    {
        _fornecedorRepository = fornecedorRepository;
    }

    public async Task AddAsync(Fornecedor fornecedor)
    {
        await _fornecedorRepository.AddAsync(fornecedor);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _fornecedorRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Fornecedor>> GetAllAsync()
    {
        return await _fornecedorRepository.GetAllAsync();
    }

    public async Task<Fornecedor?> GetByCNPJ(string cnpj)
    {
        return await _fornecedorRepository.GetByCNPJ(cnpj);
    }

    public async Task<Fornecedor?> GetByIdAsync(Guid id)
    {
        return await _fornecedorRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Fornecedor fornecedor)
    {
        await _fornecedorRepository.UpdateAsync(fornecedor);
    }
}

