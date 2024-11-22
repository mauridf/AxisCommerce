using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos
{
    public class ProdutoPrecoService : IProdutoPrecoService
    {
        private readonly IProdutoPrecoRepository _precoRepository;

        public ProdutoPrecoService(IProdutoPrecoRepository precoRepository) { _precoRepository = precoRepository;}

        public async Task AddAsync(ProdutoPreco produtoPreco)
        {
            await _precoRepository.AddAsync(produtoPreco);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _precoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProdutoPreco>> GetAllAsync()
        {
            return await _precoRepository.GetAllAsync();
        }

        public async Task<ProdutoPreco?> GetByIdAsync(Guid id)
        {
            return await _precoRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(ProdutoPreco produtoPreco)
        {
            await _precoRepository.UpdateAsync(produtoPreco);
        }
    }
}
