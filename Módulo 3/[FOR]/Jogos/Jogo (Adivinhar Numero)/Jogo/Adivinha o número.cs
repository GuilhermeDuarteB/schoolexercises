Random Random = new Random();
int random_num = Random.Next(0, 101);

for (int i = 0;i < 10; i++)
{
    Console.WriteLine("Inserir Tentativa");
    int tentativa = Convert.ToInt32(Console.ReadLine());
    
    if (tentativa == random_num)
    {
        Console.WriteLine("Parabéns, adivinhaste o número secreto!");
        return;
    }

    if (tentativa > random_num)
    {
        Console.WriteLine("Tenta novamente, o número secreto é menor do que a tua resposta!");
    }
    
    if (tentativa < random_num)
    {
        Console.WriteLine("Tenta novamente, o número secreto é maior do que a tua resposta!");
    }
}