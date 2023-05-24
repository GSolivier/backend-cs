// O usuário digita 5 numeros inteiros
// processar o dobro de cada um
// exibir ao usuário

int[] numeros = new int[5];

for (var i = 0; i < 5; i++)
{
    
Console.WriteLine($"Digite o {i + 1}º número: ");
numeros[i] = int.Parse(Console.ReadLine());

}

foreach (var item in numeros)
{
    Console.WriteLine($"O dobro de {item} é {item * 2}");
    
}

