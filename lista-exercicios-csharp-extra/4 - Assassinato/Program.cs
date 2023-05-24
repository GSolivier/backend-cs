// Será feita 5 perguntas para o usuário, são elas: Telefonou para a vítima? - Esteve no local do crime? - Mora perto da vitima? - Devia para a vítima? - Já trabalhou com a vítima?
//Caso duas dessas perguntas sejam respondidas corretamente, o usuário será considerado "SUSPEITO"
// Entre 3 e 4 como cúmplice
// e 5 como culpada
// caso contrário, seá inocente

Console.WriteLine($"Você telefonou para a vitíma?");
string tel = Console.ReadLine().ToLower();

Console.WriteLine($"Esteve no local do crime?");
string local = Console.ReadLine().ToLower();

Console.WriteLine($"Mora perto da vitima?");
string morar = Console.ReadLine().ToLower();

Console.WriteLine($"Devia para a vítima?");
string dev = Console.ReadLine().ToLower();

Console.WriteLine($"Já trabalhou com a vítima?");
string trabalho = Console.ReadLine().ToLower();

string resposta = "sim";

int contador = 0;

if (tel == resposta)
{
    contador++;
}
if(local == resposta){
    contador++;
}
if(morar == resposta){
    contador++;
}
if(dev == resposta){
    contador++;
}
if(trabalho == resposta){
    contador++;
}



if(contador == 5)
    {
        Console.WriteLine($"Você é culpado!");
    }

    else if(contador <= 4 && contador >= 3)
    {
        Console.WriteLine($"Você é cúmplice!");
        
    }

    else if(contador == 2)
    {
        Console.WriteLine($"Você é suspeito!");
        
    }

    else{
        Console.WriteLine($"Você é inocente!");
        
    }

   