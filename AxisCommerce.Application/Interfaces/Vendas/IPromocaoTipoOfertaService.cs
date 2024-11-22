using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface IPromocaoTipoOfertaService
{
    Task AddAsync(PromocaoTipoOferta promocaoTipoOferta);
    Task<PromocaoTipoOferta?> GetByIdAsync(Guid id);
    Task<IEnumerable<PromocaoTipoOferta>> GetAllAsync();
    Task UpdateAsync(PromocaoTipoOferta promocaoTipoOferta);
    Task DeleteAsync(Guid id);
}
