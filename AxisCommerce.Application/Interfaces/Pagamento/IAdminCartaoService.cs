using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Application.Interfaces.Pagamento;

public interface IAdminCartaoService
{
    Task AddAsync(AdminCartao adminCartao);
    Task<AdminCartao?> GetByIdAsync(Guid id);
    Task<IEnumerable<AdminCartao>> GetAllAsync();
    Task UpdateAsync(AdminCartao adminCartao);
    Task DeleteAsync(Guid id);
}
