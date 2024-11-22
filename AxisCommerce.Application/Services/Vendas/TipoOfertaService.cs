using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class TipoOfertaService : ITipoOfertaService
{
    private readonly ITipoOfertaRepository _tipoOfertaRepository;

    public TipoOfertaService(ITipoOfertaRepository tipoOfertaRepository)
    {
        _tipoOfertaRepository = tipoOfertaRepository;
    }

    public async Task AddAsync(TipoOferta tipoOferta)
    {
        await _tipoOfertaRepository.AddAsync(tipoOferta);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _tipoOfertaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<TipoOferta>> GetAllAsync()
    {
        return await _tipoOfertaRepository.GetAllAsync();
    }

    public async Task<TipoOferta?> GetByIdAsync(Guid id)
    {
        return await _tipoOfertaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(TipoOferta tipoOferta)
    {
        await _tipoOfertaRepository.UpdateAsync(tipoOferta);
    }
}
