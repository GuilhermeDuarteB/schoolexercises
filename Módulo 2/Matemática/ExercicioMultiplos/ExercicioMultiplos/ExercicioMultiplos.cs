int num1, num2;
Console.WriteLine("Inserir o primeiro número inteiro");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserir o segundo número inteiro");
num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Os números são múltiplos");
}
else
{
    Console.WriteLine("Os números não são múltiplos");
}