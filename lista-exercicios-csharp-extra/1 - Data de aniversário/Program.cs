//Perguntar ao usuário o dia, mes e ano de seu aniversário, e verificar se a dara é valida
//todos os meses tem 31 dias, e estamos no ano de 2013

Console.WriteLine($"Digite o dia do seu aniversário: ");
int dia = int.Parse(Console.ReadLine());

if (dia <= 0 || dia > 31)
{
    Console.WriteLine($"Coloque um dia entre 1 e 31!");
}
else 
{
    Console.WriteLine($"Digite o mes do seu aniversário: ");
    int mes = int.Parse(Console.ReadLine());

    if (mes <= 0 || mes > 12)
   {
    Console.WriteLine($"Coloque um mês entre 1 e 12!");
   }

   else{

        Console.WriteLine($"Digite o ano do seu aniversário: ");
        int ano = int.Parse(Console.ReadLine());

        if(ano > 2013 || ano <= 0)
        {
            Console.WriteLine($"Digite um ano válido");
        }

        else{
            Console.WriteLine($"Sua data de nascimento é {dia}/{mes}/{ano}");
            
        }

   }
  
}







