double fatorial, numero;
fatorial = 0;
Console.WriteLine("Inserir número");
numero = Convert.ToInt32(Console.ReadLine());
for (int i = 0;i < numero; i++)
{
    fatorial = fatorial + i;
}
Console.WriteLine("O número fatorial do número " + numero + " é " + fatorial);