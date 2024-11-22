using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Application.Interfaces.Vendas;

public interface IPromocaoGrupoService
{
    Task AddAsync(PromocaoGrupo promocaoGrupo);
    Task<PromocaoGrupo?> GetByIdAsync(Guid id);
    Task<IEnumerable<PromocaoGrupo>> GetAllAsync();
    Task UpdateAsync(PromocaoGrupo promocaoGrupo);
    Task DeleteAsync(Guid id);
}
