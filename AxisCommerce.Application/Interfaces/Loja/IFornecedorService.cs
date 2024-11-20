using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Application.Interfaces.Loja;

public interface IFornecedorService
{
    Task AddAsync(Fornecedor fornecedor);
    Task<Fornecedor?> GetByIdAsync(Guid id);
    Task<Fornecedor?> GetByCNPJ(string cnpj);
    Task<IEnumerable<Fornecedor>> GetAllAsync();
    Task UpdateAsync(Fornecedor fornecedor);
    Task DeleteAsync(Guid id);
}
