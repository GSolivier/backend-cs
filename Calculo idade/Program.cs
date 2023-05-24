//Entrada: Numero da idade do usuário
//Processamento: Calcular a idade em meses, dias, horas e minutos
//Imprimir os valores para o usuário

Console.Write("Digite o seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

float meses = idade * 12;
int dias = idade * 365;
int horas = idade * 8766;
int minutos = idade * 525960;

Console.WriteLine($"{nome}, voce viveu durante {meses} meses, ou {dias} dias, ou {horas} horas, ou {minutos} minutos");




