using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Application.Interfaces.Loja;

public interface ILojaHorarioService
{
    Task AddAsync(LojaHorario lojaHorario);
    Task<LojaHorario?> GetByIdAsync(Guid id);
    Task<IEnumerable<LojaHorario>> GetAllAsync();
    Task UpdateAsync(LojaHorario lojaHorario);
    Task DeleteAsync(Guid id);
}
