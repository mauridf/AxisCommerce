using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface IPromocaoTipoOfertaRepository
{
    Task AddAsync(PromocaoTipoOferta promocaoTipoOferta);
    Task<PromocaoTipoOferta?> GetByIdAsync(Guid id);
    Task<IEnumerable<PromocaoTipoOferta>> GetAllAsync();
    Task UpdateAsync(PromocaoTipoOferta promocaoTipoOferta);
    Task DeleteAsync(Guid id);
}
