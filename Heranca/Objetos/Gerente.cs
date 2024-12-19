namespace Heranca.Objetos;

/// <summary>
/// Objeto que representa um Gerente.
/// </summary>
public class Gerente : Funcionario
{
    public Gerente(
        string nome,
        decimal salarioHora
        )
    {
        Nome = nome;
        Cargo = "Gerente";
        SalarioHora = salarioHora;
    }

    /// <summary>
    /// Calculo de sálario mais bonus.
    /// </summary>
    /// <returns></returns>
    public override decimal CalcularSalario() 
        => (SalarioHora * 168) + 500;
}
