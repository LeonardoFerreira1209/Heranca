namespace Heranca.Objetos;

/// <summary>
/// Objeto que representa um Vendedor.
/// </summary>
public class Vendedor : Funcionario
{
    public Vendedor(
        string nome,
        decimal salarioHora
        )
    {
        Nome = nome;
        Cargo = "Vendedor";
        SalarioHora = salarioHora;
    }

    /// <summary>
    /// Calculo de sálario.
    /// </summary>
    /// <returns></returns>
    public override decimal CalcularSalario() 
        => SalarioHora * 168;
}
