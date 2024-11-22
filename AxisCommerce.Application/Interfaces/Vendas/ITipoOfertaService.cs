using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface ITipoOfertaService
{
    Task AddAsync(TipoOferta tipoOferta);
    Task<TipoOferta?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoOferta>> GetAllAsync();
    Task UpdateAsync(TipoOferta tipoOferta);
    Task DeleteAsync(Guid id);
}
