int Par, Impar, Soma, Numero;

Par = 0;
Impar = 0;
Numero = 0;

while (Numero != -1)
{
    Console.WriteLine("Inserir Número");
    Numero = Convert.ToInt32(Console.ReadLine());
    if (Numero % 2 == 0)
    {
        Par = Par + Numero;
    }
    else
    {
        Impar = Impar + Numero;
    }
}
Console.WriteLine("A soma de todos os números Pares é " + Par);
Console.WriteLine("A soma de todos os números Impares é " + Impar); 