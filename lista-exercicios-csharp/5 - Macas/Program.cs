//Ler a quantidade de macas que foram compradas
//se a quantidade de macas for menor que doze, elas custam R$0,30. Caso 12 ou mais sejam compradas, elas custam R$0,25
// mostrar o valor total da compra

Console.WriteLine($"Quantas maçãs você comprou?");
int macas = int.Parse(Console.ReadLine());

if (macas < 12)
{
   double valorSemDesconto = macas * 0.30; 
   Console.WriteLine($"A sua compra teve um total de R${Math.Round(valorSemDesconto, 2)}");
}
else{
    double valorComDesconto = macas * 0.25;
    Console.WriteLine($"A sua compra teve um total de R${Math.Round(valorComDesconto, 2)}");
}
