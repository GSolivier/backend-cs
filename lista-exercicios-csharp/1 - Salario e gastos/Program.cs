// Usuario devera informar o salario e os gastos
// Analisar se os gastos sao maiores ou menores que o orcamento
// retornar para o usuario

Console.WriteLine("Digite o seu salário: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine("Digite os seus gastos: ");
float gastos = float.Parse(Console.ReadLine());

if(gastos <= salario)
{
    Console.WriteLine($"Seus gastos estão dentro do orcamento, parabéns!");
    
}
else
{
    Console.WriteLine($"Você estourou seu orcamento, cuidado!");
}


