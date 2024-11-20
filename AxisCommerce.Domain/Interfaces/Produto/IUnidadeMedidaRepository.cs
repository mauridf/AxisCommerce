using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IUnidadeMedidaRepository
{
    Task AddAsync(UnidadeMedida unidadeMedida);
    Task<UnidadeMedida?> GetByIdAsync(Guid id);
    Task<UnidadeMedida?> GetBySimbolo(string simbolo);
    Task<IEnumerable<UnidadeMedida>> GetAllAsync();
    Task UpdateAsync(UnidadeMedida unidadeMedida);
    Task DeleteAsync(Guid id);
}
