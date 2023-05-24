// O usuário digita 3 números
// fazer a comparação para saber o menor e o maior deles
// retornar valor para o usuário

Console.WriteLine($"Digite o primeiro número");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o terceiro número");
float n3 = float.Parse(Console.ReadLine());

if (n1 > n2)
{
    if(n1 > n3)
    Console.WriteLine($"O maior número digitado é o {n1}");

    else{
        Console.WriteLine($"O maior número digitado é o {n3}");
    }
}

else{
    if(n2 > n3)
    {
        Console.WriteLine($"O maior número digitado é o {n2}");
    }
    else{
        Console.WriteLine($"O maior número digitado é o {n3}");
    }
}

if (n1 < n2)
{
    if(n1 < n3)
    Console.WriteLine($"O maior número digitado é o {n1}");

    else{
        Console.WriteLine($"O maior número digitado é o {n3}");
    }
}

else{
    if(n2 < n3)
    {
        Console.WriteLine($"O maior número digitado é o {n2}");
    }
    else{
        Console.WriteLine($"O maior número digitado é o {n3}");
    }
}






