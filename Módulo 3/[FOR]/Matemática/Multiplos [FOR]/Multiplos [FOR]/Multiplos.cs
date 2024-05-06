Console.WriteLine("Digite um número inteiro de 1 a 10 ");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 100; i++)
{
    if (i % numero == 0)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();