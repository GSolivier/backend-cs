// Pedir ao usuário o raio de uma circunferência de um circulo
//retornar para o usário o diametro, comprimento e área de circunferencia

Console.WriteLine($"Digite o raio do círculo: ");
float raio = float.Parse(Console.ReadLine());

float pi = 3.14f;

float diametro = raio * 2;
float comprimento = 2 * pi * raio;
float area = pi * raio * raio;

Console.WriteLine($"Com um raio de {raio}, o círculo em questão tem {diametro} de diametro, {comprimento} de comprimento e {area} de área!");

