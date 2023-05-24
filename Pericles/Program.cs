// 1. Pedir para o usuário adivinhar a idade do Péricles.
// 2. Validar a idade até o usuário acertar.
int idadeP;
do
{
Console.WriteLine($"Qual a idade do Péricles?");
idadeP = int.Parse(Console.ReadLine());
    
} while (idadeP != 53);

Console.WriteLine($"Idade correta. Parabéns!");

