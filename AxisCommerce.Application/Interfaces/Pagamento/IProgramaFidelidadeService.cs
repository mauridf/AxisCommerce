using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Application.Interfaces.Pagamento;

public interface IProgramaFidelidadeService
{
    Task AddAsync(ProgramaFidelidade programaFidelidade);
    Task<ProgramaFidelidade?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProgramaFidelidade>> GetAllAsync();
    Task UpdateAsync(ProgramaFidelidade programaFidelidade);
    Task DeleteAsync(Guid id);
}
