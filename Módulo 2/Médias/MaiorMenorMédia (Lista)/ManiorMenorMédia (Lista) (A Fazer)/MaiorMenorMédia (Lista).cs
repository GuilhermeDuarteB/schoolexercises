int Numeros, NMaior, NMenor, total, vezes;
double Media;
Numeros = 0;
NMaior = 0;
total = 0;
vezes= 0;

Console.WriteLine("Inserir um Número");
Numeros = Convert.ToInt32(Console.ReadLine());
NMenor = Numeros;

while (Numeros != -1)
{
    if (NMenor < Numeros)
    {

    }
    else
    {
        NMenor = Numeros;
    }
    Console.WriteLine("Inserir um Número");
    Numeros = Convert.ToInt32(Console.ReadLine());
    total = total + Numeros;
    if (Numeros > NMaior)
    {
        NMaior = Numeros;
    }
    vezes = vezes + 1;
}
Media = (total / vezes);
Console.WriteLine("A Média da lista é " + Media);
Console.WriteLine("O Menor numero da lista é " + NMenor);
Console.WriteLine("O Maior numero da lista é " + NMaior);