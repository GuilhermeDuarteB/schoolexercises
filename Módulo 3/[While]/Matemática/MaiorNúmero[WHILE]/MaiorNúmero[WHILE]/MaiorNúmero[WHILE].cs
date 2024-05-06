int NMaior=0,Resposta, fim=0;

Console.WriteLine("Insira uma lista de 10 números");

while (fim!=10)
{
    Resposta = Convert.ToInt32(Console.ReadLine());
    if (Resposta > NMaior)
    {
        NMaior = Resposta;
    }
    else if (NMaior> Resposta)
    {
    }
    fim = fim + 1;
 }

Console.WriteLine("O maior número da lista é " + NMaior);