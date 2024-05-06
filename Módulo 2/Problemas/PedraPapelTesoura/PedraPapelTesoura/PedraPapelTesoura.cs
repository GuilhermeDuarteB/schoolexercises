float Resposta;
Random Random = new Random();
int rand_num = Random.Next(1, 4);
// 1=Pedra, 2=Papel, 3=Tesoura
Console.WriteLine("Por favor insira o seu resultado com os seguintes dados:");
Console.WriteLine("1 = Pedra, 2 = Papel, 3 = Tesoura");
Resposta = Convert.ToInt32(Console.ReadLine());
if (Resposta == 1 & rand_num == 1)
{
    Console.WriteLine("Ambos os jogadores escolheram Pedra por isso foi empate.");
}
else if (Resposta == 1 & rand_num == 2)
{
    Console.WriteLine("PERDESTE!");
}
else if (Resposta == 1 & rand_num == 3)
{
    Console.WriteLine("GANHASTE!");
}
else if (Resposta == 2 & rand_num == 1)
{
    Console.WriteLine("GANHASTE!");
}
else if (Resposta == 2 & rand_num == 2)
{
    Console.WriteLine("Ambos os jogadores escolheram Papel por isso foi empate.");
}
else if (Resposta == 2 & rand_num == 3)
{
    Console.WriteLine("PERDESTE!");
}
else if (Resposta == 3 & rand_num == 1)
{
    Console.WriteLine("PERDESTE!");
}   
else if (Resposta == 3 & rand_num == 2)
{
    Console.WriteLine("GANHASTE!");
}
else if (Resposta == 3 & rand_num == 3)
{
    Console.WriteLine("Ambos os jogadores escolheram Tesoura por isso foi empate.");
}