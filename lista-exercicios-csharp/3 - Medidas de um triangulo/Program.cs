//Ler as medidas dos lados de um triangulo
//Determinar se o triangulo informado é Equilatero, isóceles ou escaleno
//informar o usuario

Console.WriteLine($"Digite a medida do primeiro lado do triangulo: ");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a medida do segundo lado do triangulo: ");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a medida do terceiro lado do triangulo: ");
float lado3 = float.Parse(Console.ReadLine());

if(lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
{
    Console.WriteLine($"Esse triângulo é equilátero.");
}
else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine($"Esse triangulo é isóceles."); 
}
else{
    Console.WriteLine($"Esse triângulo é escaleno.");
}


