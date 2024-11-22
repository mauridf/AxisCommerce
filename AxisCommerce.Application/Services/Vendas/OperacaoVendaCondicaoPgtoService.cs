using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class OperacaoVendaCondicaoPgtoService : IOperacaoVendaCondicaoPgtoService
{
    private readonly IOperacaoVendaCondicaoPgtoRepository _operacaoVendaCondicaoPgtoRepository;

    public OperacaoVendaCondicaoPgtoService(IOperacaoVendaCondicaoPgtoRepository operacaoVendaCondicaoPgtoRepository)
    {
        _operacaoVendaCondicaoPgtoRepository = operacaoVendaCondicaoPgtoRepository;
    }

    public async Task AddAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto)
    {
        await _operacaoVendaCondicaoPgtoRepository.AddAsync(operacaoVendaCondicaoPgto);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _operacaoVendaCondicaoPgtoRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<OperacaoVendaCondicaoPgto>> GetAllAsync()
    {
        return await _operacaoVendaCondicaoPgtoRepository.GetAllAsync();
    }

    public async Task<OperacaoVendaCondicaoPgto?> GetByIdAsync(Guid id)
    {
        return await _operacaoVendaCondicaoPgtoRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(OperacaoVendaCondicaoPgto operacaoVendaCondicaoPgto)
    {
        await _operacaoVendaCondicaoPgtoRepository.UpdateAsync(operacaoVendaCondicaoPgto);
    }
}
