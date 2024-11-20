using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Domain.Interfaces.Pagamento;

public interface IAdminCartaoRepository
{
    Task AddAsync(AdminCartao adminCartao);
    Task<AdminCartao?> GetByIdAsync(Guid id);
    Task<IEnumerable<AdminCartao>> GetAllAsync();
    Task UpdateAsync(AdminCartao adminCartao);
    Task DeleteAsync(Guid id);
}
