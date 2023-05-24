Console.Write($"Digite o seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao sistema escolar {nome}!");

Console.WriteLine($"Digite sua nota em Matemática:");
float mat = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota em Portugues:");
float port = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota em Geografia:");
float geo = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota em Fisíca:");
float fis = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite sua nota em Quimíca:");
float quim = float.Parse(Console.ReadLine());

float media = (mat + port + geo + fis + quim) / 5;

Console.WriteLine($"{nome}, a sua média nesse bimestre foi de {media}!");
