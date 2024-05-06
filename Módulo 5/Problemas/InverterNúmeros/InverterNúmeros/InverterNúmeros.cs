int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Insira os números que pretende inverter");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.WriteLine("Números invertidos");
    Console.WriteLine(numeros[i]);
}