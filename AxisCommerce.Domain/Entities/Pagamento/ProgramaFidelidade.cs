namespace AxisCommerce.Domain.Entities.Pagamento;

public class ProgramaFidelidade
{
    public Guid Id { get; set; }
    public string DescProgramaFidelidade { get; set; } = string.Empty;
    public DateOnly PontuacaoDataInicio { get; set; }
    public DateOnly PontuacaoDataFinal { get; set; }
    public string PontuacaoFormula { get; set; } = string.Empty;
    public string PontuacaoRecibo { get; set; } = string.Empty;
    public DateOnly ResgateDataInicio { get; set; }
    public DateOnly ResgateDataFinal { get; set; }
    public string ResgateFormula { get; set; } = string.Empty;
    public string ResgateRecibo { get; set; } = string.Empty;
    public int ResgateSaldoMinimo { get; set; } = 0;
}
