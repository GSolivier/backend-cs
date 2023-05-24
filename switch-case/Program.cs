// switch(expression)
// {
//     case x:
//     //bloco de código
//     break;

//     case y:
//     //bloco de código
//     break;

//     case z:
//     //bloco de código
//     break;

//     case a:
//     //bloco de código
//     break;

//     default:
//     //bloco de código
//     break;

// }
Console.WriteLine($"Informe o número correspondente ao dia da semana: ");

int diaDaSemana = int.Parse(Console.ReadLine());

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine($"Domingo");
    break;

    case 2:
        Console.WriteLine($"Segunda");
    break;

    case 3:
        Console.WriteLine($"Terça");
    break;

    case 4:
        Console.WriteLine($"Quarta");
    break;

    case 5:
        Console.WriteLine($"Quinta");
    break;

    case 6:
        Console.WriteLine($"Sexta");
    break;

    case 7:
        Console.WriteLine($"Sábado");
    break;


    default:
        Console.WriteLine($"Informe um dia da semana válido (Exemplo: Digite '5' para Quinta).");
    break;    
}