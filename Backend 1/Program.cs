string nome = "Guilherme";
float peso = 100;
float altura = 1.80f;

float imc = peso / (altura * altura);

Console.WriteLine("O IMC do " + nome + " é de " +  Math.Round(imc, 2));

