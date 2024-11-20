using AxisCommerce.Domain.Entities.Vendas;

namespace AxisCommerce.Domain.Interfaces.Venda;

public interface IPromocaoGrupoRepository
{
    Task AddAsync(PromocaoGrupo promocaoGrupo);
    Task<PromocaoGrupo?> GetByIdAsync(Guid id);
    Task<IEnumerable<PromocaoGrupo>> GetAllAsync();
    Task UpdateAsync(PromocaoGrupo promocaoGrupo);
    Task DeleteAsync(Guid id);
}
