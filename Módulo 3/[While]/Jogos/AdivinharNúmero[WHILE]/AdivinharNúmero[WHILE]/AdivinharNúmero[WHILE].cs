Random Random = new Random();
int random_num = Random.Next(0, 101);
int tentativas = 0;
int resposta;
do
{
    Console.WriteLine("Inserir resposta");
    resposta = Convert.ToInt32(Console.ReadLine());
    if (resposta < random_num)
    {
        Console.WriteLine("Erraste, o número secreto é maior que a sua resposta");
        tentativas++;
    }
    if (random_num < resposta)
    {
        Console.WriteLine("Erraste, o número secreto é menor que a sua resposta");
        tentativas++;
    }
    if (random_num == resposta)
    {
        Console.WriteLine("Parabéns adivinhaste o número secreto");
        tentativas++;
    }
} while (resposta != random_num);
Console.WriteLine("Para acertares precisaste de " + tentativas);