using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos
{
    public interface IProdutoCorBasicaService
    {
        Task AddAsync(ProdutoCorBasica produtoCorBasica);
        Task<ProdutoCorBasica?> GetByIdAsync(Guid id);
        Task<IEnumerable<ProdutoCorBasica>> GetAllAsync();
        Task UpdateAsync(ProdutoCorBasica produtoCorBasica);
        Task DeleteAsync(Guid id);
    }
}
