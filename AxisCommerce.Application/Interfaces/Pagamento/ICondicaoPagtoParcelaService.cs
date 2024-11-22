﻿using AxisCommerce.Domain.Entities.Pagamento;

namespace AxisCommerce.Application.Interfaces.Pagamento;

public interface ICondicaoPagtoParcelaService
{
    Task AddAsync(CondicaoPagtoParcela condicaoPagtoParcela);
    Task<CondicaoPagtoParcela?> GetByIdAsync(Guid id);
    Task<IEnumerable<CondicaoPagtoParcela>> GetAllAsync();
    Task UpdateAsync(CondicaoPagtoParcela condicaoPagtoParcela);
    Task DeleteAsync(Guid id);
}
