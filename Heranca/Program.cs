
using Heranca.Objetos;

var vendedor = new Vendedor(
    "Lucas", 60
);

Console.WriteLine(
    $"Instância criada vendedor: {vendedor.Nome}, Sálario mensal: {vendedor.CalcularSalario():N2}"
);

var gerente = new Gerente(
    "Diego", 100
);

Console.WriteLine(
    $"Instância criada gerente: {gerente.Nome}, Sálario mensal: {gerente.CalcularSalario():N2}"
);