// Criar um menu de bebidas, e pedir para o usuário escolher a de sua preferência.
// Depois, perguntar para o usuário se ele quer gelo na bebida
// Se sim, exibir a bebida com o gelo, se não, exibir que a bebida virá sem gelo

Console.Clear();

Console.WriteLine(@"
-------------------------------------------------
|       MENU DE BEBIDAS AUTOMÁTICA v1.0         |
|                                               |
|    Bem vindo(a) ao nosso menu de bebidas      |
|    automático.                                |
|    Por favor, escolha qual a bebida que       |
|    deseja experimentar hoje.                  |
|                                               |
|     1 - Coca-Cola                             |
|     2 - Fanta                                 |
|     3 - Guaraná                               |
|     4 - Pepsi                                 |
|     5 - Sprite                                |
-------------------------------------------------
");
int bebida = int.Parse(Console.ReadLine());

switch (bebida)
{
    
    case 1:
    Console.WriteLine($"A bebida escolhida foi a Coca-Cola. Você gostaria de acrescentar gelo na sua bebida? Digite 'Sim' ou 'Não'.");
        break;
    
    case 2:
    Console.WriteLine($"A bebida escolhida foi a Fanta. Você gostaria de acrescentar gelo na sua bebida? Digite 'Sim' ou 'Não'.");
        break;
    
    case 3:
    Console.WriteLine($"A bebida escolhida foi a Guaraná. Você gostaria de acrescentar gelo na sua bebida? Digite 'Sim' ou 'Não'.");
        break;
    
    case 4:
    Console.WriteLine($"A bebida escolhida foi a Pepsi. Você gostaria de acrescentar gelo na sua bebida? Digite 'Sim' ou 'Não'.");
        break;
    
    case 5:
    Console.WriteLine($"A bebida escolhida foi a Sprite. Você gostaria de acrescentar gelo na sua bebida? Digite 'Sim' ou 'Não'.");
        break;

    default:
    Console.WriteLine($"Escolha um número de bebida válido.");
    
    break;
}

string gelo = Console.ReadLine().ToLower();

if(gelo == "sim")
{
    Console.WriteLine($"A sua bebida terá gelo.");
}

else if(gelo == "nao" || gelo == "não"){
    Console.WriteLine($"A sua bebida terá gelo.");
}

else{
    Console.WriteLine($"Resposta inválida. Tente Novamente.");
} 






