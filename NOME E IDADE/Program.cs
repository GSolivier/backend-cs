﻿string[] nome = new string[5];
int[] idade = new int[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome:");
    nome[i] = Console.ReadLine();
    
    Console.WriteLine($"Digite a {i + 1}ª idade:");
    idade[i] = int.Parse(Console.ReadLine());  
}

for (var i = 0; i < 5; i++)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{i + 1}) ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Nome: {nome[i]}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"   Idade: {idade[i]} anos");
Console.ResetColor();
Console.WriteLine();
}

