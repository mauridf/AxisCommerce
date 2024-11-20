using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Domain.Interfaces.Loja;

public interface ILojaRepository
{
    Task AddAsync(Lojas loja);
    Task<Lojas?> GetByIdAsync(Guid id);
    Task<Lojas?> GetByCodLoja(string codLoja);
    Task<IEnumerable<Lojas>> GetAllAsync();
    Task UpdateAsync(Lojas loja);
    Task DeleteAsync(Guid id);
}
