int[,] numeros = new int[8, 1];

for (int i=0; i != numeros.Length; i++)
{
    Console.WriteLine("Insira os números que pretende saber a média dos pares e dos impares");
    numeros[i, 0] = Convert.ToInt32(Console.ReadLine());
}

int pares = 0, impares = 0, paresconta = 0, imparesconta = 0;
for (int i = 0; i < numeros.GetLength(0); i++)
{
    if (numeros[i, 0] % 2 == 0)
    {
        pares += numeros[i, 0];
        paresconta++;
    }
    else
    {
        impares += numeros[i, 0];
        imparesconta++;
    }
}
double MediaImpares = impares / imparesconta;
double MediaPares = pares / paresconta;

Console.WriteLine("A média dos números pares é " + MediaPares);
Console.WriteLine("A média dos números impares é " + MediaImpares);
