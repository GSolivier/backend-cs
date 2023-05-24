//Verificar a validade da senha inserida pelo usuário. A senha correta é 1234
//Retornar para o usuário se o acesso foi concedido ou não

Console.WriteLine($"Digite sua senha...");
string senhaU = Console.ReadLine();

string senhaC = "1234";

if(senhaU == senhaC)
{
    Console.WriteLine($"ACESSO CONCEDIDO.");
}
else
{
    Console.WriteLine($"ACESSO NEGADO");
}