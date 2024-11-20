using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Domain.Interfaces.Loja;

public interface ITransportadoraRepository
{
    Task AddAsync(Transportadora transportadora);
    Task<Transportadora?> GetByIdAsync(Guid id);
    Task<Transportadora?> GetByCNPJ(string cnpj);
    Task<IEnumerable<Transportadora>> GetAllAsync();
    Task UpdateAsync(Transportadora transportadora);
    Task DeleteAsync(Guid id);
}
