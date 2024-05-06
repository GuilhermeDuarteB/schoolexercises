// See https://aka.ms/new-console-template for more information
int idade;

Console.WriteLine("Inserir idade");
idade = Convert.ToInt32(Console.ReadLine());
if (idade >= 18)
{
    Console.WriteLine("És maior de idade");
}
if (idade <18)
{
    Console.WriteLine("És menor de idade");
}