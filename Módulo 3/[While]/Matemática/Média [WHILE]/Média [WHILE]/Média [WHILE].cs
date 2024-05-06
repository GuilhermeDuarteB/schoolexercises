int Total = 0, resposta, Vezes, fim;
float Media;
fim = 0;
Vezes = 0;
Media = 0;
Console.WriteLine("Inserir números inteiros positivos");
while (fim != -1)
{
    resposta = Convert.ToInt32(Console.ReadLine());
    Total = resposta + Total;
    fim = resposta;
    Console.WriteLine("Caso queira parar digite -1");
    if (resposta == -1)
    {
        break;
    }
    Vezes = Vezes + 1;
}

Media = (Total / Vezes);
Console.WriteLine("A média de todos os " + Vezes + " números inseridos é " + Media);