for (int i = 100; i <= 999; i++)
{
    int num = i;
    int somaCubos = 0;

    while (num > 0)
    {
        int digito = num % 10;
        somaCubos += (int)Math.Pow(digito, 3);
        num /= 10;
    }

    if (somaCubos == i)
    {
        Console.WriteLine(i);
    }
}