using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Application.Interfaces.Pagamento;

public interface IMoedaIndicadorService
{
    Task AddAsync(MoedaIndicador moedaIndicador);
    Task<MoedaIndicador?> GetByIdAsync(Guid id);
    Task<IEnumerable<MoedaIndicador>> GetAllAsync();
    Task UpdateAsync(MoedaIndicador moedaIndicador);
    Task DeleteAsync(Guid id);
}
