using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Domain.Interfaces.Produtos;

public interface IArtigoBrindeRepository
{
    Task AddAsync(ArtigoBrinde artigoBrinde);
    Task<ArtigoBrinde?> GetByIdAsync(Guid id);
    Task<IEnumerable<ArtigoBrinde>> GetAllAsync();
    Task UpdateAsync(ArtigoBrinde artigoBrinde);
    Task DeleteAsync(Guid id);
}
