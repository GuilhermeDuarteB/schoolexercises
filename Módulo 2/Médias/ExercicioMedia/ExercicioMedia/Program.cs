int num1;
int num2;
double media;

do
{
    Console.WriteLine("Inserir Primeiro Número");
    num1 = Convert.ToInt32(Console.ReadLine());
} while (num1 <= 0);

do
{
    Console.WriteLine("Inserir Segundo Número");
    num2 = Convert.ToInt32(Console.ReadLine());
} while (num2 <= 0);

media = num1 + num2;
media = media / 2;
Console.WriteLine("A sua média é " + media);
