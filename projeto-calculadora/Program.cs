// 1. O usuário informa a operação
// 2. O usuário informa os dois valores
// 3. Validação do processamento
// 4. Retornar o valor para o usuário.

Console.WriteLine(@$"
_____________________________________________________
|            CALCULADORA v1.0                       |
|                                                   |
|    Informe qual operação você deseja calcular:    |
|                                                   |
|    Digite '+' para somar.                         |
|    Digite '-' para subtrair.                      |   
|    Digite '*' para multiplicar.                   |
|    Digite '/' para dividir.                       |
|___________________________________________________|
");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Agora, informe o primeiro valor que deseja calcular: ");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora, informe o segundo valor que deseja calcular: ");
float num2 = float.Parse(Console.ReadLine());

float resultado = 0;

switch (operacao)
{
    case '+':
    resultado = num1 + num2;
        break;
        
    case '-':
    resultado = num1 - num2;
        break;

    case '*':
    resultado = num1 * num2;
        break;

    case '/':
    resultado = num1 / num2;
        break;

    default:
    Console.WriteLine(@$"Nossa calculadora está em processo de desenvolvimento e não suporta o tipo de operação informada.
    Por favor, digite uma das operações informadas anteriormente.");
    
        break;
}


