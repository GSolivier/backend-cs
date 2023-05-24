// Usuario informa o placar de um jogo de futebol
// compara para ver que time esta ganhando ou se esta empatando
// retorna o valor para o usuario

Console.WriteLine("Digite o nome do time mandante: ");
string? time1 = Console.ReadLine();

Console.WriteLine("Digite a quantidade de gols do mandante: ");
int golsTime1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do time visitante: ");
string? time2 = Console.ReadLine();

Console.WriteLine("Digite a quantidade de gols do time visitante: ");
int golsTime2 = int.Parse(Console.ReadLine());


if(golsTime1 > golsTime2)
{
    Console.WriteLine($"O {time1} está vencendo o {time2} pelo placar de {golsTime1} X {golsTime2}.");
    
}
else if(golsTime1 < golsTime2)
{
    Console.WriteLine($"O {time2} está vencendo o {time1} pelo placar de {golsTime1} X {golsTime2}.");
    
}

else{
    Console.WriteLine($"O {time1} está empatando com o {time2} pelo placar de {golsTime1} X {golsTime2}.");
}




