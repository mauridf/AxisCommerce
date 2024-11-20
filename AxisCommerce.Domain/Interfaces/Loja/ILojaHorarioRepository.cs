using AxisCommerce.Domain.Entities.Loja;

namespace AxisCommerce.Domain.Interfaces.Loja;

public interface ILojaHorarioRepository
{
    Task AddAsync(LojaHorario lojaHorario);
    Task<LojaHorario?> GetByIdAsync(Guid id);
    Task<IEnumerable<LojaHorario>> GetAllAsync();
    Task UpdateAsync(LojaHorario lojaHorario);
    Task DeleteAsync(Guid id);
}
