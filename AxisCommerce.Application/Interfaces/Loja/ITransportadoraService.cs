using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Application.Interfaces.Loja;

public interface ITransportadoraService
{
    Task AddAsync(Transportadora transportadora);
    Task<Transportadora?> GetByIdAsync(Guid id);
    Task<Transportadora?> GetByCNPJ(string cnpj);
    Task<IEnumerable<Transportadora>> GetAllAsync();
    Task UpdateAsync(Transportadora transportadora);
    Task DeleteAsync(Guid id);
}
