using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Domain.Interfaces.Pagamento;

public interface IProgramaFidelidadeRepository
{
    Task AddAsync(ProgramaFidelidade programaFidelidade);
    Task<ProgramaFidelidade?> GetByIdAsync(Guid id);
    Task<IEnumerable<ProgramaFidelidade>> GetAllAsync();
    Task UpdateAsync(ProgramaFidelidade programaFidelidade);
    Task DeleteAsync(Guid id);
}
