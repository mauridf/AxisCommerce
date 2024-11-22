using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Application.Interfaces.Pedidos;

public interface IMotivoDevolucaoService
{
    Task AddAsync(MotivoDevolucao motivoDevolucao);
    Task<MotivoDevolucao?> GetByIdAsync(Guid id);
    Task<IEnumerable<MotivoDevolucao>> GetAllAsync();
    Task UpdateAsync(MotivoDevolucao motivoDevolucao);
    Task DeleteAsync(Guid id);
}
