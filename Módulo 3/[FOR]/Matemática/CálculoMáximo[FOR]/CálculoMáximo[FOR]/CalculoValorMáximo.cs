int numeros, NMaximo = 0;
Console.WriteLine("Inserir lista de 6 números para calcular o máximo");

for (int i=0; i <6; i++)
{
    numeros = Convert.ToInt32(Console.ReadLine());
    NMaximo = NMaximo + numeros;
}
Console.WriteLine("O valor máximo da lista é " + NMaximo);