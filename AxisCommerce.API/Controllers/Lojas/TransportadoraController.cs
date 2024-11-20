using AxisCommerce.API.Atributes;
using AxisCommerce.Application.Interfaces.Loja;
using AxisCommerce.Domain.Entities.Loja;
using Microsoft.AspNetCore.Mvc;

namespace AxisCommerce.API.Controllers.Loja
{
    [ApiController]
    [ApiVersion("1.0"), ApiGroup(ApiGroupNames.Loja)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TransportadoraController : ControllerBase
    {
        private readonly ITransportadoraService _transportadoraService;

        public TransportadoraController(ITransportadoraService transportadoraService)
        {
            _transportadoraService = transportadoraService;
        }

        [HttpGet("transportadoras")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var transportadoras = await _transportadoraService.GetAllAsync();
                return Ok(transportadoras);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno ao obter todos as transportadoras.", error = ex.Message });
            }
        }

        [HttpGet("transportadora-por-id/{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var transportadora = await _transportadoraService.GetByIdAsync(id);
                if (transportadora == null) return NotFound(new { message = "Transportadora não encontrada." });
                return Ok(transportadora);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno ao buscar transportadora por ID.", error = ex.Message });
            }
        }

        [HttpPost("cadastrar-transportadora")]
        public async Task<IActionResult> Create(Transportadora transportadora)
        {
            try
            {
                await _transportadoraService.AddAsync(transportadora);
                return CreatedAtAction(nameof(GetById), new { id = transportadora.Id }, transportadora);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new { message = "Dados incompletos para cadastro de transportadora.", error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno ao cadastrar transportadora.", error = ex.Message });
            }
        }

        [HttpPut("alterar-transportadora/{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Transportadora transportadora)
        {
            try
            {
                if (id != transportadora.Id) return BadRequest();
                await _transportadoraService.UpdateAsync(transportadora);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno ao atualizar transportadora.", error = ex.Message });
            }
        }

        [HttpDelete("deletar-transportadora/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _transportadoraService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno ao deletar transportadora.", error = ex.Message });
            }
        }
    }
}
