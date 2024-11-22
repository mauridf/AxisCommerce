using AxisCommerce.Domain.Entities.Produtos;

namespace AxisCommerce.Application.Interfaces.Produtos;

public interface IArtigoBrindeService
{
    Task AddAsync(ArtigoBrinde artigoBrinde);
    Task<ArtigoBrinde?> GetByIdAsync(Guid id);
    Task<IEnumerable<ArtigoBrinde>> GetAllAsync();
    Task UpdateAsync(ArtigoBrinde artigoBrinde);
    Task DeleteAsync(Guid id);
}
