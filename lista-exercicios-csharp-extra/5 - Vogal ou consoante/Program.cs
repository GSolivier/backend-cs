//Ler uma letra digitada pelo usuario
//verificar se é vogal ou consoante
//retornar o valor para o usuário

Console.WriteLine($"Digite uma letra do alfabeto: ");
string letraU = Console.ReadLine().ToLower();



if (letraU == "a" || letraU == "e" || letraU ==  "i" || letraU == "o" || letraU == "u")
{
    Console.WriteLine($"A letra digitada é vogal!");
    
}

else
{
    Console.WriteLine($"A letra digitada é consoante!");
    
}
