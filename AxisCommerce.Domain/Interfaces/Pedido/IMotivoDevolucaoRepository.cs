using AxisCommerce.Domain.Entities.Pedidos;

namespace AxisCommerce.Domain.Interfaces.Pedidos;

public interface IMotivoDevolucaoRepository
{
    Task AddAsync(MotivoDevolucao motivoDevolucao);
    Task<MotivoDevolucao?> GetByIdAsync(Guid id);
    Task<IEnumerable<MotivoDevolucao>> GetAllAsync();
    Task UpdateAsync(MotivoDevolucao motivoDevolucao);
    Task DeleteAsync(Guid id);
}
