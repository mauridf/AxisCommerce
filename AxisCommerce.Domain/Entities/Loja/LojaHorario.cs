using System.Text.Json.Serialization;

namespace AxisCommerce.Domain.Entities.Loja;

public class LojaHorario
{
    public Guid Id { get; set; }
    public Guid LojaId { get; set; }
    [JsonIgnore]
    public Lojas? Loja { get; set; }
    public int DiaFuncionamento { get; set; }
    public TimeOnly HoraInicio { get; set; }
    public TimeOnly? HoraFim { get; set; }
}
