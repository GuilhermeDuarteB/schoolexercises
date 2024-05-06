int[] números = new int[5];
for (int i = 0; i != números.Length; i++)
{
    Console.WriteLine("Por favor insira os números que pretende calcular a sua soma");
    números[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("A soma de todos os números inseridos é " + números.Sum());