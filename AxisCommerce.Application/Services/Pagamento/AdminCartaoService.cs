using AxisCommerce.Application.Interfaces.Pagamento;
using AxisCommerce.Domain.Entities.Pagamento;
using AxisCommerce.Domain.Interfaces.Pagamento;
using System.Runtime.CompilerServices;

namespace AxisCommerce.Application.Services.Pagamento;

public class AdminCartaoService : IAdminCartaoService
{
    private readonly IAdminCartaoRepository _adminCartaoRepository;

    public AdminCartaoService(IAdminCartaoRepository adminCartaoRepository)
    {
        _adminCartaoRepository = adminCartaoRepository;
    }

    public async Task AddAsync(AdminCartao adminCartao)
    {
        await _adminCartaoRepository.AddAsync(adminCartao);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _adminCartaoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<AdminCartao>> GetAllAsync()
    {
        return await _adminCartaoRepository.GetAllAsync();
    }

    public async Task<AdminCartao?> GetByIdAsync(Guid id)
    {
        return await _adminCartaoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(AdminCartao adminCartao)
    {
        await _adminCartaoRepository.UpdateAsync(adminCartao);
    }
}
