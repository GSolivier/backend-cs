static float Somar(float n1, float n2)
{
    return n1 + n2;
}

static float Subtrair(float n1, float n2)
{
    return n1 - n2;
}

static float Dividir(float n1, float n2)
{
    return n1 / n2;
}

static float Multiplicar(float n1, float n2)
{
    return n1 * n2;
}

Console.WriteLine($"Informe o primeiro número:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número:");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a operação desejada: '+' '-' '*' '/'");
char op = char.Parse(Console.ReadLine());

switch (op)
{
    case '+':
        Console.WriteLine($"A soma desses dois números é {Somar(n1,n2)}");
        break;
    case '-':
        Console.WriteLine($"A subtração desses dois números é {Subtrair(n1,n2)}");
        break;
    case '*':
        Console.WriteLine($"A multiplicação desses dois números é {Multiplicar(n1,n2)}");
        break;
    case '/':
        Console.WriteLine($"A divisão desses dois números é {Dividir(n1,n2)}");
        break;
    default:
        break;
}













