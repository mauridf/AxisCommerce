using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface ITipoOfertaRepository
{
    Task AddAsync(TipoOferta tipoOferta);
    Task<TipoOferta?> GetByIdAsync(Guid id);
    Task<IEnumerable<TipoOferta>> GetAllAsync();
    Task UpdateAsync(TipoOferta tipoOferta);
    Task DeleteAsync(Guid id);
}
