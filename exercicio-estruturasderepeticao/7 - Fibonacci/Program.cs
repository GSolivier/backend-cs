int num1 = 0, num2 = 1, resultado;
        
Console.WriteLine("Série de Fibonacci até que o valor seja maior que 500:");
Console.Write($"{num1} {num2} ");
        
resultado = num1 + num2;
        
while (resultado < 500) 
{
    Console.Write($"{resultado} ");
    num1 = num2;
    num2 = resultado;
    resultado = num1 + num2;
 }

 Console.WriteLine($"{resultado}");
 
        