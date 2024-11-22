using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class PromocaoGrupoService : IPromocaoGrupoService
{
    private readonly IPromocaoGrupoRepository _promocaoGrupoRepository;

    public PromocaoGrupoService(IPromocaoGrupoRepository promocaoGrupoRepository)
    {
        _promocaoGrupoRepository = promocaoGrupoRepository;
    }

    public async Task AddAsync(PromocaoGrupo promocaoGrupo)
    {
        await _promocaoGrupoRepository.AddAsync(promocaoGrupo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _promocaoGrupoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PromocaoGrupo>> GetAllAsync()
    {
        return await _promocaoGrupoRepository.GetAllAsync();
    }

    public async Task<PromocaoGrupo?> GetByIdAsync(Guid id)
    {
        return await _promocaoGrupoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PromocaoGrupo promocaoGrupo)
    {
        await _promocaoGrupoRepository.UpdateAsync(promocaoGrupo);
    }
}
