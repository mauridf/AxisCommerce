using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class OperacaoVendaService : IOperacaoVendaService
{
    private readonly IOperacaoVendaRepository _operacaoVendaRepository;

    public OperacaoVendaService(IOperacaoVendaRepository operacaoVendaRepository)
    {
        _operacaoVendaRepository = operacaoVendaRepository;
    }

    public async Task AddAsync(OperacaoVenda operacaoVenda)
    {
        await _operacaoVendaRepository.AddAsync(operacaoVenda);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _operacaoVendaRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<OperacaoVenda>> GetAllAsync()
    {
        return await _operacaoVendaRepository.GetAllAsync();
    }

    public async Task<OperacaoVenda?> GetByIdAsync(Guid id)
    {
        return await _operacaoVendaRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(OperacaoVenda operacaoVenda)
    {
        await _operacaoVendaRepository.UpdateAsync(operacaoVenda);
    }
}
