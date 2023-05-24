// Ler primeiro a frenquencia do aluno, caso for menor que 75%, ele será reprovado.
// Caso seja maior, sera avaliada a media do aluno, se a média for maior ou igual a 7 ele será aprovado
//Se a media for maior que 3 e menor que 7, ele ficara de recuperação
//mas se a média for menor ou igual a 3, ele estara reprovado

Console.WriteLine($"Digite a frequência do aluno: ");
float freq = float.Parse(Console.ReadLine());

if (freq < 75)
{
    Console.WriteLine($"O ALUNO ESTÁ REPROVADO! FREQUÊNCIA ABAIXO DE 75%.");
    
}
else 
{
    Console.WriteLine($"Digite a média do aluno no semestre:");
    float media = float.Parse(Console.ReadLine());
    
    if(media >= 7)
    {
        Console.WriteLine($"O ALUNO ESTÁ APROVADO! PARABÉNS!");
        
    }

    else if (media > 3)
    {
        Console.WriteLine($"O ALUNO ESTÁ DE RECUPERAÇÃO! DIRIJA-SE Á SECRETARIA!");
        
    }
    else{
        Console.WriteLine($"O ALUNO ESTÁ REPROVADO!");
        
    }
}
