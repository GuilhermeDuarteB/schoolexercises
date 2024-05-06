int Numeros, NMaior;
Numeros = 0;
NMaior = 0;

Console.WriteLine("Inserir um Número");
Numeros = Convert.ToInt32(Console.ReadLine());
NMaior = Numeros;

while (Numeros != -1)
{    if (NMaior < Numeros)
    {

    }
    else
    {
        NMaior = Numeros;
    }
    Console.WriteLine("Inserir um Número");
    Numeros = Convert.ToInt32(Console.ReadLine());
    if (Numeros > NMaior)
    {
        NMaior = Numeros;
    }
}
Console.WriteLine("O maior numero da lista é " + NMaior);