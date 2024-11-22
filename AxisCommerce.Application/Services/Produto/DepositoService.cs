using AxisCommerce.Application.Interfaces.Produtos;
using AxisCommerce.Domain.Entities.Produtos;
using AxisCommerce.Domain.Interfaces.Produtos;

namespace AxisCommerce.Application.Services.Produtos;

public class DepositoService : IDepositoService
{
    private readonly IDepositoRepository _depositoRepository;

    public DepositoService(IDepositoRepository depositoRepository)
    {
        _depositoRepository = depositoRepository;
    }

    public async Task AddAsync(Deposito deposito)
    {
        await _depositoRepository.AddAsync(deposito);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _depositoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Deposito>> GetAllAsync()
    {
        return await _depositoRepository.GetAllAsync();
    }

    public async Task<Deposito?> GetByIdAsync(Guid id)
    {
        return await _depositoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Deposito deposito)
    {
        await _depositoRepository.UpdateAsync(deposito);
    }
}
