//Criar u método para calcular imposto de renda
// até 1500 - isento
// 1501 a 3500 - 20%
// 3501 a 6000 - 25%
// acima de 6000 - 35%

// receber via console
// chamar o método passando a renda como parametro
// exibir o valor do imposto referente a renda.
using System.Globalization;


static double ImpostoDeRenda(double imposto)
{
    if (imposto <= 1500)
    {
        return 0;
    }

    else if (imposto <= 3500)
    {
        return imposto * 0.20;
    }

    else if(imposto <= 6000)
    {
        return imposto * 0.25;
    }

    else{
        return imposto * 0.35;
    }
    
}

Console.WriteLine($"Digite seu salário:");
double salario = double.Parse(Console.ReadLine());

double impostoDevido  = ImpostoDeRenda(salario);

Console.WriteLine($"O valor do imposto é {impostoDevido.ToString("C", new CultureInfo(""))}");
