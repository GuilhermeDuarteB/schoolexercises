int sequencia;
int n1 = 0;
int n2 = 1;

Console.WriteLine("Quantas sequencias queres fazer?");
sequencia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n1);
Console.WriteLine(n2);

for (int i = 0; i < sequencia - 2; i++)
{

    int temp = n2;
    n2 = n1 + n2;
    n1 = temp;
    Console.WriteLine(n2);
}