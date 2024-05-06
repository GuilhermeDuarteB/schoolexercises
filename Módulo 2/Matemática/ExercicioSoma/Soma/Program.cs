// See https://aka.ms/new-console-template for more information

//Declarar variáveis
int primeiroNumero;
int segundoNumero;
int soma;

//Escrever linha na conola
Console.WriteLine("Inserir o primeiro número");
//Converter a variável inteiro para string (texto)
primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserir o segundo número");
segundoNumero = Convert.ToInt32(Console.ReadLine());

soma = primeiroNumero + segundoNumero;
Console.WriteLine("O valor total é " + soma);

    