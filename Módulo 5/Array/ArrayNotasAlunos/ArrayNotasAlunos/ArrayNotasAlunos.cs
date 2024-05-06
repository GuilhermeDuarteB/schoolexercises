Console.WriteLine("Quantas notas pretende inserir no programa?");
int NumNotas = Convert.ToInt32(Console.ReadLine());

int[] notas = new int[NumNotas];

for (int i = 0;i != notas.Length; i++)
{
    Console.WriteLine("Insira as notas dos alunos (0-20)");
    notas[i] = Convert.ToInt32(Console.ReadLine());
    if (notas[i] > 20)
    {
        Console.WriteLine("Nota inválida, lembrando que as notas são de 0-20");
        i--;
    }
}

Console.WriteLine("A menor nota registada é " + notas.Min());
Console.WriteLine("A maior nota registada é " + notas.Max());