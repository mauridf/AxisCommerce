using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Domain.Interfaces.Pagamento;

public interface IMoedaIndicadorRepository
{
    Task AddAsync(MoedaIndicador moedaIndicador);
    Task<MoedaIndicador?> GetByIdAsync(Guid id);
    Task<IEnumerable<MoedaIndicador>> GetAllAsync();
    Task UpdateAsync(MoedaIndicador moedaIndicador);
    Task DeleteAsync(Guid id);
}
