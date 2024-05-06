using System.Security.Cryptography.X509Certificates;

int num;
Console.WriteLine("Por favor insira um número inteiro");
num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("O " + num + " é um número par"); 
}
else
{
    Console.WriteLine("O " + num + " é um número ímpar");
}
Console.ReadKey();