int[] idades = new int[5];

for (int i = 0; i != idades.Length; i++)
{
    Console.WriteLine("Insira a sua idade");
    idades[i] = Convert.ToInt32(Console.ReadLine());
}
decimal Media;
Media = 0;
int idadestotal = 0;
for (int i = 0; i < idades.Length; i++)
{
    idadestotal = idadestotal + idades[i];
}

Media = idadestotal / idades.Length;

Console.WriteLine("A média é " + Media);