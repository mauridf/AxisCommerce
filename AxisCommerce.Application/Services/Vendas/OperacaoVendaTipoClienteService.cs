using AxisCommerce.Application.Interfaces.Vendas;
using AxisCommerce.Domain.Entities.Vendas;
using AxisCommerce.Domain.Interfaces.Venda;

namespace AxisCommerce.Application.Services.Vendas;

public class OperacaoVendaTipoClienteService : IOperacaoVendaTipoClienteService
{
    private readonly IOperacaoVendaTipoClienteRepository _operacaoVendaTipoClienteRepository;

    public OperacaoVendaTipoClienteService(IOperacaoVendaTipoClienteRepository operacaoVendaTipoClienteRepository)
    {
        _operacaoVendaTipoClienteRepository = operacaoVendaTipoClienteRepository;
    }

    public async Task AddAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente)
    {
        await _operacaoVendaTipoClienteRepository.AddAsync(operacaoVendaTipoCliente);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _operacaoVendaTipoClienteRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<OperacaoVendaTipoCliente>> GetAllAsync()
    {
        return await _operacaoVendaTipoClienteRepository.GetAllAsync();
    }

    public async Task<OperacaoVendaTipoCliente?> GetByIdAsync(Guid id)
    {
        return await _operacaoVendaTipoClienteRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(OperacaoVendaTipoCliente operacaoVendaTipoCliente)
    {
        await _operacaoVendaTipoClienteRepository.UpdateAsync(operacaoVendaTipoCliente);
    }
}
