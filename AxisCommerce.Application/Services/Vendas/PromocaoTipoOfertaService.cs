using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class PromocaoTipoOfertaService : IPromocaoTipoOfertaService
{
    private readonly IPromocaoTipoOfertaRepository _promoTipoOfertaRepository;

    public PromocaoTipoOfertaService(IPromocaoTipoOfertaRepository promoTipoOfertaRepository)
    {
        _promoTipoOfertaRepository = promoTipoOfertaRepository;
    }

    public async Task AddAsync(PromocaoTipoOferta promocaoTipoOferta)
    {
        await _promoTipoOfertaRepository.AddAsync(promocaoTipoOferta);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _promoTipoOfertaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<PromocaoTipoOferta>> GetAllAsync()
    {
        return await _promoTipoOfertaRepository.GetAllAsync();
    }

    public async Task<PromocaoTipoOferta?> GetByIdAsync(Guid id)
    {
        return await _promoTipoOfertaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(PromocaoTipoOferta promocaoTipoOferta)
    {
        await _promoTipoOfertaRepository.UpdateAsync(promocaoTipoOferta);
    }
}
