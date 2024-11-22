using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos
{
    public interface IProdutoService
    {
        Task AddAsync(Produto produto);
        Task<Produto?> GetByIdAsync(Guid id);
        Task<IEnumerable<Produto>> GetAllAsync();
        Task UpdateAsync(Produto produto);
        Task DeleteAsync(Guid id);
    }
}
