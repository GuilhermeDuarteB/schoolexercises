int Resposta;
Console.WriteLine("Bem vindo nadador, por favor insira a sua idade para continuar!");
Resposta = Convert.ToInt32(Console.ReadLine());
if (Resposta <= 6)
{
    Console.WriteLine("Parabéns, estás inserido nos Golfinhos!");

}
else if (Resposta >= 7 && Resposta <= 10) 
{
    Console.WriteLine("Parabéns, estás inserido nos Infantis!");
}
if (Resposta >= 11 && Resposta <= 13)
{
    Console.WriteLine("Parabéns, estás inserido nos Juvenis!");
}
else if (Resposta >= 14 && Resposta <= 17)
{
    Console.WriteLine("Parabéns, estás inserido nos Tubarões!");
}
if (Resposta >=18)
{
    Console.WriteLine("Parabéns, estás inserido nos Cotas!");
}