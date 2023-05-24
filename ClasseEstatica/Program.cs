using System.Globalization;
using ClasseEstatica;


bool loopBreak = true;
float realUser;
float dollarUser;

List<>

// Console.WriteLine($"{ConversorMoeda.RealToDollar(100)}");
// Console.WriteLine($"{ConversorMoeda.DollarToReal(100)}");

do
{
Console.WriteLine(@$"
        Conversor de Moedas

    [1] - Real para dólar
    [2] - Dólar para real
    [3] - Sair
");

string escolhaMenu = Console.ReadLine();

switch (escolhaMenu)
{
    case "1":
    Console.WriteLine($"Digite o valor que deseja converter:");
    realUser = float.Parse(Console.ReadLine());

    Console.WriteLine($"O valor {realUser} em reais, é equivalente a USD{ConversorMoeda.RealToDollar(realUser).ToString("C", new CultureInfo("en-US"))}");
    
        break;

    case "2":
    Console.WriteLine($"Digite o valor que deseja converter:");
    dollarUser = float.Parse(Console.ReadLine());

    Console.WriteLine($"O valor {dollarUser} em dollar, é equivalente a {ConversorMoeda.DollarToReal(dollarUser).ToString("C", new CultureInfo("pt-BR"))}");

        break;

    case "3":
    Console.GetCursorPosition();
    Console.WriteLine($"Saindo do programa...");
    Thread.Sleep(3000);
    loopBreak = false;
    break;
    default:
    Console.WriteLine($"Digite uma opção válida!");
        break;
}  
} while (loopBreak);

